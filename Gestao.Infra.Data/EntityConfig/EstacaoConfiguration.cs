using System.Data.Entity.ModelConfiguration;
using Gestao.Domain.Entities;

namespace Gestao.Infra.Data.EntityConfig
{
    public class EstacaoConfiguration : EntityTypeConfiguration<Estacao>
    {
        public EstacaoConfiguration()
        {
            HasKey(e => e.EstacaoId);

            Property(e => e.Hostname)
                .IsRequired();

            Property(e => e.Setor)
                .IsRequired();

            Property(e => e.EnderecoIp)
                .IsRequired();

            Property(e => e.SistemaOperacional)
                .IsRequired();

            Property(e => e.ChavedeAtivacao)
                .IsRequired();

        }
    }
}
