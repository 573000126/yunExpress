using System;
using System.Linq;
using System.Collections.Generic;

using System.Linq.Expressions;
using LMS.Data.Context;
using LMS.Data.Entity;
using LighTake.Infrastructure.Seedwork.EF;
using System.Transactions;
using LighTake.Infrastructure.Common;

// This file is auto generated and will be overwritten as soon as the template is executed
// Do not modify this file...

namespace LMS.Data.Repository
{
    public partial class MailTotalPackageInfoRepository
    {
        static object _lockSaveMainPostBagTag = new object();

        /// <summary>
        /// �����ܰ��� �� �ܰ��븣�ʵĹ�ϵ
        /// </summary>
        /// <param name="mainPostTag">�ִܾ���</param>
        /// <param name="re">��ϵ����</param>
        /// <returns></returns>
        public bool SaveMainPostBagTag(MailTotalPackageInfo mainPostTag, MailTotalPackageOrPostBagRelational re)
        {
            var ctx = this.UnitOfWork as LMS_DbContext;  
           
            lock (_lockSaveMainPostBagTag)
            {
                if (ctx.MailTotalPackageOrPostBagRelationals.Any(t => t.PostBagNumber == re.PostBagNumber))
                {
                    throw new BusinessLogicException("[���ʴ��ƺ�]�Ѿ�ɨ�����.");
                }
                
                using (var tran = new TransactionScope(TransactionScopeOption.Required))
                {
                    if (!ctx.MailTotalPackageInfos.Any(t => t.MailTotalPackageNumber == mainPostTag.MailTotalPackageNumber)) //������
                    {
                        DateTime fiveDaysAgo = DateTime.Now.AddDays(-5);

                        //5��֮ǰ�Ƿ����
                        if (ctx.MailTotalPackageInfos.Any(t => t.TotalPackageNumber == mainPostTag.TotalPackageNumber && t.CreatedOn >= fiveDaysAgo))
                        {
                            //�滻MailTotalPackageNumber
                            mainPostTag.MailTotalPackageNumber = ctx.MailTotalPackageInfos
                                  .Where(t => t.TotalPackageNumber == mainPostTag.TotalPackageNumber && t.CreatedOn >= fiveDaysAgo)
                                  .OrderByDescending(p => p.CreatedOn)
                                  .Select(t => t.MailTotalPackageNumber)
                                  .FirstOrDefault();
                        }
                        else
                        {
                            //insert MailTotalPackageInfo
                            ctx.MailTotalPackageInfos.Add(mainPostTag);
                        }
                    }

                    //insert MailTotalPackageOrPostBagRelational
                    re.MailTotalPackageNumber = mainPostTag.MailTotalPackageNumber;
                    ctx.MailTotalPackageOrPostBagRelationals.Add(re);

                    ctx.SaveChanges();
                    tran.Complete();
                }

                return true;
            }
            // throw new NotImplementedException();
        }
    }
}
