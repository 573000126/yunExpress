using System;
using System.Linq;
using System.Collections.Generic;

using System.Linq.Expressions;

using LighTake.Infrastructure.Common;
using LighTake.Infrastructure.Seedwork;
using LMS.Data.Entity;

// This file is auto generated and will be overwritten as soon as the template is executed
// Do not modify this file...
	
namespace LMS.Data.Repository
{   
	public partial interface IMailTotalPackageInfoRepository 
	{
        /// <summary>
        /// �����ܰ��� �� �ܰ��븣�ʵĹ�ϵ
        /// </summary>
        /// <param name="mainPostTag">�ִܾ���</param>
        /// <param name="re">��ϵ����</param>
        /// <returns></returns>
        bool SaveMainPostBagTag(MailTotalPackageInfo mainPostTag, MailTotalPackageOrPostBagRelational re);


	}
}
