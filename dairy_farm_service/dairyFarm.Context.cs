﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dairy_farm_service
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dairyFarmEntities : DbContext
    {
        public dairyFarmEntities()
            : base("name=dairyFarmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cattle> Cattle { get; set; }
        public DbSet<CattleProduction> CattleProductions { get; set; }
        public DbSet<CattleType> CattleTypes { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<DiseaseHistory> DiseaseHistories { get; set; }
        public DbSet<FoodComsuption> FoodComsuptions { get; set; }
        public DbSet<FoodStock> FoodStocks { get; set; }
        public DbSet<Gestation> Gestations { get; set; }
        public DbSet<HealthStatu> HealthStatus { get; set; }
        public DbSet<Herd> Herds { get; set; }
    }
}