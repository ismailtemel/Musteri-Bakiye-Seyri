//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Musteri_Bakiye_Seyri_.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MusteriDbEntities : DbContext
    {
        public MusteriDbEntities()
            : base("name=MusteriDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MUSTERİ_FATURA_TABLE> MUSTERİ_FATURA_TABLE { get; set; }
        public virtual DbSet<MUSTERİ_TANIM_TABLE> MUSTERİ_TANIM_TABLE { get; set; }
    }
}
