
using System.Data.Entity.ModelConfiguration;
using Gestao.Domain.Entities;

namespace Gestao.Infra.Data.EntityConfig
{
    public class ImpressoraConfiguration : EntityTypeConfiguration<Impressora>
    {
        public ImpressoraConfiguration()
        {
            HasKey(i => i.ImpressoraId);

            Property(i => i.Nome)
                .IsRequired();

            Property(i => i.EnderecoIp)
                .IsRequired();

            Property(i => i.Setor)
                .IsRequired();

            Property(i => i.Marca)
                .IsRequired();

            Property(i => i.Modelo)
                .IsRequired();

            HasRequired(i => i.Estacao)
                .WithMany()
                .HasForeignKey(i => i.EstacaoId);
        }
    }
}
