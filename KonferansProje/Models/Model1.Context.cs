﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KonferansProje.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbEntities : DbContext
    {
        public DbEntities()
            : base("name=DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin_tbl> admin_tbl { get; set; }
        public virtual DbSet<katilimci_tbl> katilimci_tbl { get; set; }
        public virtual DbSet<konferans_tbl> konferans_tbl { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
