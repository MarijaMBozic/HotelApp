﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelAppEntities : DbContext
    {
        public HotelAppEntities()
            : base("name=HotelAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Engagement> Engagements { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Menager> Menagers { get; set; }
        public virtual DbSet<QualificationLevel> QualificationLevels { get; set; }
        public virtual DbSet<RoleUser> RoleUsers { get; set; }
        public virtual DbSet<UserHotel> UserHotels { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }
}