using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Gestao.Domain.Entities;


namespace Gestao.Infra.Data.Contexto
{
    public class GestorContexto : DbContext
    {
        public GestorContexto()
            : base("GestorAtivos")
        {

        }

        public DbSet<CadastroComputador> CadastroComputadores { get; set; }         
        public DbSet<CadastroAplicacao> CadastroAplicacoes { get; set; }
        public DbSet<CadastroFuncao> CadastroFuncoes { get; set; }
        public DbSet<CadastroLicenciamento> CadastroLicenciamentos { get; set; }
        public DbSet<CadastroServidor> CadastroServidores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

           modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Entity<CadastroComputador>() 
                .HasKey(p => p.ComputadorId);

            modelBuilder.Entity<CadastroAplicacao>()
                .HasKey(p => p.AppId);

            modelBuilder.Entity<CadastroFuncao>()
                .HasKey(p => p.FuncaoId);

            modelBuilder.Entity<CadastroLicenciamento>()
                 .HasKey(p => p.LicenciamentoId);

            modelBuilder.Entity<CadastroServidor>()
                 .HasKey(p => p.ServidorId);

        }
    }
}
