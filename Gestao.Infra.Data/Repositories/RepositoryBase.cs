using System;
using System.Collections.Generic;
using Gestao.Domain.Interfaces;
using Gestao.Infra.Data.Contexto;

namespace Gestao.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected GestorContexto Db = new GestorContexto();

        public void Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
