﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampWebsite.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbCampEntities : DbContext
    {
        public dbCampEntities()
            : base("name=dbCampEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tCampsite> tCampsite { get; set; }
        public virtual DbSet<tComment> tComment { get; set; }
        public virtual DbSet<tMember> tMember { get; set; }
        public virtual DbSet<tOptionCase> tOptionCase { get; set; }
        public virtual DbSet<tOrder> tOrder { get; set; }
        public virtual DbSet<tRent> tRent { get; set; }
        public virtual DbSet<tTag> tTag { get; set; }
        public virtual DbSet<tTent> tTent { get; set; }
        public virtual DbSet<tTentPhoto> tTentPhoto { get; set; }
        public virtual DbSet<tBooked> tBooked { get; set; }
    }
}
