﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement_380.Models.DbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Sandhya_380Entities6 : DbContext
    {
        public Sandhya_380Entities6()
            : base("name=Sandhya_380Entities6")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<States> States { get; set; }
    
        public virtual ObjectResult<Sp_state_country_city_Result> Sp_state_country_city()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_state_country_city_Result>("Sp_state_country_city");
        }
    
        public virtual ObjectResult<state_country_Result> state_country()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<state_country_Result>("state_country");
        }
    
        public virtual ObjectResult<state_country_city_Result> state_country_city()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<state_country_city_Result>("state_country_city");
        }
    }
}
