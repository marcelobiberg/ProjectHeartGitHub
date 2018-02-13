namespace ProjectHeart.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloDados : DbContext
    {
        public ModeloDados()
            : base("name=ModeloDados")
        {
        }

        public virtual DbSet<Convenio> Convenios { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //n quero qu epluralize as colunas na tabela
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            /*Desabilitamos o delete em cascata em relacionamentos 1:N evitando
            ter registros filhos     sem registros pai*/
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Basicamente a mesma configuração, porém em relacionamenos N:N
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Model Account
            modelBuilder.Entity<Account>()
              .Property(e => e.ID_USER)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //primary key
            modelBuilder.Entity<Account>()
                .HasKey(e => e.ID_USER);

            modelBuilder.Entity<Account>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.SENHA)
                .IsUnicode(false);
            // end Model Account

            //Model Convenio
            modelBuilder.Entity<Convenio>()
              .Property(e => e.ID_CONVENIO)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //primary key
            modelBuilder.Entity<Convenio>()
            .HasKey(e => e.ID_CONVENIO);

            modelBuilder.Entity<Convenio>()
                .Property(e => e.NR_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<Convenio>()
                .Property(e => e.NOME_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<Convenio>()
                .Property(e => e.VALIDADE)
                .HasColumnType("datetime");
            // end Model Convenio

            //Model Paciente
            modelBuilder.Entity<Paciente>()
              .Property(e => e.ID_PACIENTE)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //primary key
            modelBuilder.Entity<Paciente>()
               .HasKey(e => e.ID_PACIENTE);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.COMPLEMENTAR)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                 .Property(e => e.STATUS)
                 .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
             .Property(e => e.DATA_NASC)
             .HasColumnType("date");

            modelBuilder.Entity<Paciente>()
             .Property(e => e.CEP)
             .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.RESPONSAVEL)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
             .Property(e => e.PROFISSAO)
             .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.UF)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
             .Property(e => e.BAIRRO)
             .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
               .Property(e => e.CELULAR)
               .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.TELEFONE2)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.NATURALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
               .Property(e => e.SMS)
               .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.CPF)
                .IsUnicode(false);
            //end Model Paciente

        }
    }
}
