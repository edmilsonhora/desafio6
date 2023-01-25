using ESH_Desafio6.ApplicationService.Views;
using System.Collections.Generic;

namespace ESH_Desafio6.ApplicationService.Interfaces
{
    public interface IFacadeBase<T> where T : ViewBase
    {
        void Salvar(T view);
        void Excluir(int id);
        T ObterPor(int id);
        List<T> ObterTodos();
    }
}
