﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityPractica.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Alumno19Entities : DbContext
    {
        public Alumno19Entities()
            : base("name=Alumno19Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Aula> Aula { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<ProfesorCurso> ProfesorCurso { get; set; }
    }
}
