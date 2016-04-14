using System.Data.Entity.ModelConfiguration;
using Gestao.Domain.Entities;

namespace Gestao.Infra.Data.EntityConfig
{
    public class ServidorConfiguration : EntityTypeConfiguration<Servidor>
    {
        public ServidorConfiguration()
        {
            HasKey(s => s.ServidorId);

            Property(s => s.Hostname)
                .IsRequired();

            Property(s => s.Funcao)
                .IsRequired();

            Property(s => s.EnderecoIp)
                .IsRequired();

            Property(s => s.SistemaOperacional)
                .IsRequired();

            Property(s => s.ChavedeAtivacao)
                .IsRequired();
        }
    }
}
