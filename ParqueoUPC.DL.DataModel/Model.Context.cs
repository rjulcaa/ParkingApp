﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParqueoUPC.DL.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ParqueoUPCEntities : DbContext
    {
        public ParqueoUPCEntities()
            : base("name=ParqueoUPCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Espacio> Espacio { get; set; }
        public virtual DbSet<Piso> Piso { get; set; }
        public virtual DbSet<TipoCliente> TipoCliente { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
    }
}
