﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PHCEntities : DbContext, IPHCEntities
    {
        public PHCEntities()
            : base("name=PHCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<AuditTrails> AuditTrails { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<NextOfKins> NextOfKins { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Counties> Counties { get; set; }
        public virtual DbSet<Occupations> Occupations { get; set; }
        public virtual DbSet<SubCounties> SubCounties { get; set; }
        public virtual DbSet<Villages> Villages { get; set; }
        public virtual DbSet<Wards> Wards { get; set; }
    }
}