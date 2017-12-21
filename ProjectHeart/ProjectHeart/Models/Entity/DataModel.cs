namespace ProjectHeart
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<CONVENIO> CONVENIOs { get; set; }
        public virtual DbSet<PACIENTE> PACIENTEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.NR_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.NOME_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .HasMany(e => e.PACIENTEs)
                .WithRequired(e => e.CONVENIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PACIENTE>()
                .Property(e => e.NOME_PACIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<PACIENTE>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<PACIENTE>()
                .Property(e => e.RESPONSAVEL)
                .IsUnicode(false);

            modelBuilder.Entity<PACIENTE>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<PACIENTE>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<PACIENTE>()
                .Property(e => e.NR_CARTEIRA)
                .IsUnicode(false);

            modelBuilder.Entity<PACIENTE>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<PACIENTE>()
                .Property(e => e.CPF)
                .IsUnicode(false);
        }
    }
}
