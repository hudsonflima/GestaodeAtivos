using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Gestao.Domain.Entities;
using Gestao.Infra.Data.EntityConfig;


namespace Gestao.Infra.Data.Contexto
{
    public class GestorContexto : DbContext
    {
        public GestorContexto()
            : base("GestorAtivos")
        {

        }

        public DbSet<Estacao> Estacoes { get; set; }         
        public DbSet<Impressora> Impressoras { get; set; }
        public DbSet<Servidor> Servidores { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

           modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Entity<Estacao>() 
                .HasKey(p => p.EstacaoId);

            modelBuilder.Entity<Impressora>()
                .HasKey(p => p.ImpressoraId);

            modelBuilder.Entity<Servidor>()
                .HasKey(p => p.ServidorId);

            modelBuilder.Configurations.Add(new EstacaoConfiguration());
            modelBuilder.Configurations.Add(new ImpressoraConfiguration());
            modelBuilder.Configurations.Add(new ServidorConfiguration());
        }
    }
}
