using ESH_Desafio6.ApplicationService.Facades;
using ESH_Desafio6.ApplicationService.Interfaces;
using ESH_Desafio6.DataAccess;
using ESH_Desafio6.DomainModel.Interfaces;

namespace ESH_Desafio6.ApplicationService
{
    public class Facade : IFacade
    {
        private IRepository _repository;
        public Facade()
        {
            _repository = new Repository();
        }

        private IAlunoFacade _alunos;

        public IAlunoFacade Alunos => _alunos ?? (_alunos = new AlunoFacade(_repository));

        public void Rollback()
        {
            _repository.RollBack();
        }

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }
    }
}
