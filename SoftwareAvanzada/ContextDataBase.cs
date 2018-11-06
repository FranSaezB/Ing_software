namespace SoftwareAvanzada
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextDataBase : DbContext
    {
        public ContextDataBase()
            : base("name=ContextDataBase")
        {
        }

        public virtual DbSet<guia> guia { get; set; }
        public virtual DbSet<reserva> reserva { get; set; }
        public virtual DbSet<tours> tours { get; set; }
        public virtual DbSet<turista> turista { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<guia>()
                .Property(e => e.email_guia)
                .IsUnicode(false);

            modelBuilder.Entity<guia>()
                .Property(e => e.password_guia)
                .IsUnicode(false);

            modelBuilder.Entity<guia>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<guia>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<guia>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<guia>()
                .Property(e => e.telefono)
                .HasPrecision(18, 0);

            modelBuilder.Entity<guia>()
                .HasMany(e => e.tours)
                .WithRequired(e => e.guia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<reserva>()
                .Property(e => e.email_turista)
                .IsUnicode(false);

            modelBuilder.Entity<tours>()
                .Property(e => e.ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<tours>()
                .Property(e => e.idioma)
                .IsUnicode(false);

            modelBuilder.Entity<tours>()
                .Property(e => e.valoracion)
                .HasPrecision(30, 6);

            modelBuilder.Entity<tours>()
                .Property(e => e.descripcion_tour)
                .IsUnicode(false);

            modelBuilder.Entity<tours>()
                .Property(e => e.descripcion_guia)
                .IsUnicode(false);

            modelBuilder.Entity<tours>()
                .Property(e => e.punto_encuentro)
                .IsUnicode(false);

            modelBuilder.Entity<tours>()
                .Property(e => e.email_guia)
                .IsUnicode(false);

            modelBuilder.Entity<tours>()
                .HasMany(e => e.reserva)
                .WithRequired(e => e.tours)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<turista>()
                .Property(e => e.email_turista)
                .IsUnicode(false);

            modelBuilder.Entity<turista>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<turista>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<turista>()
                .Property(e => e.telefono)
                .HasPrecision(18, 0);

            modelBuilder.Entity<turista>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<turista>()
                .HasMany(e => e.reserva)
                .WithRequired(e => e.turista)
                .WillCascadeOnDelete(false);
        }
    }
}
