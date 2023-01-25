using ESH_Desafio6.DomainModel.Interfaces;
using ESH_Desafio6.DomainModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace ESH_Desafio6.DataAccess.Repositories
{
    public abstract class AbstractRepository<T> : IRepositoryBase<T> where T : EntityBase, IEntityBase
    {
       private readonly DdDataContext _context;

        public AbstractRepository(DdDataContext context)
        {
            this._context = context;
        }

        public void Excluir(T entity)
        {
            _context.GetTable<T>().DeleteOnSubmit(entity);
        }

        public T ObterPor(int id)
        {
            return _context.GetTable<T>().FirstOrDefault(p => p.Id.Equals(id));
        }

        public List<T> ObterTodos()
        {
            return _context.GetTable<T>().ToList();
        }

        public void Salvar(T entity)
        {
            if (entity.Id == 0)
                _context.GetTable<T>().InsertOnSubmit(entity);
        }
    }
}
