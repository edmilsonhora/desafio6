using ESH_Desafio6.DomainModel.Models;
using System.Collections.Generic;

namespace ESH_Desafio6.DomainModel.Interfaces
{
    public interface IRepositoryBase<T> where T : EntityBase, IEntityBase
    {
        void Salvar(T entity);
        void Excluir(T entity);
        List<T> ObterTodos();
        T ObterPor(int id);
    }
}
