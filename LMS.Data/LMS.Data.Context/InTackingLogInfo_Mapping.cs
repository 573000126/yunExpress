//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure;
using LMS.Data.Entity;

namespace LMS.Data.Context
{
    #pragma warning disable 1573
    
    
    internal partial class InTackingLogInfo_Mapping : EntityTypeConfiguration<InTackingLogInfo>
    {
        public InTackingLogInfo_Mapping()
        {					
    		this.HasKey(t => t.ID);		
    		this.ToTable("InTackingLogInfos");
    		this.Property(t => t.ID).HasColumnName("ID");
    		this.Property(t => t.WaybillNumber).HasColumnName("WaybillNumber").HasMaxLength(50);
    		this.Property(t => t.ProcessDate).HasColumnName("ProcessDate");
    		this.Property(t => t.ProcessContent).HasColumnName("ProcessContent").HasMaxLength(300);
    		this.Property(t => t.ProcessLocation).HasColumnName("ProcessLocation").HasMaxLength(100);
    		this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
    		this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
    		this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
    		this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
    		this.Property(t => t.Remarks).HasColumnName("Remarks").HasMaxLength(500);
    	}
    }
}
