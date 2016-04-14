using System.Collections;
using System.Collections.Generic;
using Gestao.Domain.Entities;

namespace Gestao.Domain.Interfaces
{
    public interface IImpressoraRepository : IRepositoryBase<Impressora>
    {
        IEnumerable<Impressora> BuscarPorNome(string nome);
    }
}
