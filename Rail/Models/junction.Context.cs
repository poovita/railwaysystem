﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rail.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class junctionEntities : DbContext
    {
        public junctionEntities()
            : base("name=junctionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<arsikere> arsikeres { get; set; }
        public virtual DbSet<bangalore> bangalores { get; set; }
        public virtual DbSet<bellary> bellaries { get; set; }
        public virtual DbSet<chikjajur> chikjajurs { get; set; }
        public virtual DbSet<dadar> dadars { get; set; }
        public virtual DbSet<gadag> gadags { get; set; }
        public virtual DbSet<guntkal> guntkals { get; set; }
        public virtual DbSet<hotgi> hotgis { get; set; }
        public virtual DbSet<hubli> hublis { get; set; }
        public virtual DbSet<kalyan> kalyans { get; set; }
        public virtual DbSet<karjat> karjats { get; set; }
        public virtual DbSet<krishnarajapurm> krishnarajapurms { get; set; }
        public virtual DbSet<kuruduvadi> kuruduvadis { get; set; }
        public virtual DbSet<latur_road> latur_road { get; set; }
        public virtual DbSet<londa> londas { get; set; }
        public virtual DbSet<madgaon> madgaons { get; set; }
        public virtual DbSet<miraj> mirajs { get; set; }
        public virtual DbSet<panvel> panvels { get; set; }
        public virtual DbSet<pune> punes { get; set; }
        public virtual DbSet<vasai_road> vasai_road { get; set; }
        public virtual DbSet<vikarabad> vikarabads { get; set; }
        public virtual DbSet<wadi> wadis { get; set; }
        public virtual DbSet<Yesvantpur> Yesvantpurs { get; set; }
    }
}
