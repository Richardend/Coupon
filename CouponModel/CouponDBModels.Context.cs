﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CouponModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CouponDBEntities : DbContext
    {
        public CouponDBEntities()
            : base("name=CouponDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alliance> Alliances { get; set; }
        public virtual DbSet<AllianceSID> AllianceSIDs { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Order_CardCode> Order_CardCode { get; set; }
        public virtual DbSet<Order_Code> Order_Code { get; set; }
        public virtual DbSet<PaymentInfo> PaymentInfoes { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Resource_SID_List> Resource_SID_List { get; set; }
        public virtual DbSet<Resource_Store> Resource_Store { get; set; }
        public virtual DbSet<ResourceCurrency> ResourceCurrencies { get; set; }
        public virtual DbSet<ResourceRepertory> ResourceRepertories { get; set; }
        public virtual DbSet<ResourceType> ResourceTypes { get; set; }
        public virtual DbSet<StoreInfo> StoreInfoes { get; set; }
    }
}
