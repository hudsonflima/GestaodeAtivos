using System.Collections.Generic;
using System.Linq;
using Gestao.Domain.Entities;
using Gestao.Domain.Interfaces;

namespace Gestao.Infra.Data.Repositories
{
    public class EstacaoRepository : RepositoryBase<Estacao>, IEstacaoRepository
    {
        public IEnumerable<Estacao> BuscarPorNome(string nome)
        {
            return Db.Estacoes.Where(e => e.Hostname == nome);
        }

    }
}
