namespace ProjectHeart.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloDados : DbContext
    {
        public ModeloDados()
            : base("name=ModeloDados")
        {
        }

        public virtual DbSet<Convenio> Convenios { get; set; }
        public virtual DbSet<LogUser> LogUsers { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Convenio>()
                .Property(e => e.NR_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<Convenio>()
                .Property(e => e.NOME_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<Convenio>()
                .HasMany(e => e.Pacientes)
                .WithRequired(e => e.Convenio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LogUser>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<LogUser>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<LogUser>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<LogUser>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.NOME_PACIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.RESPONSAVEL)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.NR_CARTEIRA)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.CPF)
                .IsUnicode(false);
        }
    }
}
