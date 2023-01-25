using ESH_Desafio6.ApplicationService.Adapters;
using ESH_Desafio6.ApplicationService.Interfaces;
using ESH_Desafio6.ApplicationService.Views;
using ESH_Desafio6.DomainModel.Interfaces;
using ESH_Desafio6.DomainModel.Models;
using System.Collections.Generic;

namespace ESH_Desafio6.ApplicationService.Facades
{
    internal class AlunoFacade : IAlunoFacade
    {
        private readonly IRepository _repository;
        public AlunoFacade(IRepository repository)
        {
            _repository = repository;
        }

        public void Excluir(int id)
        {
            var obj = _repository.Alunos.ObterPor(id);
            if (obj != null)
                _repository.Alunos.Excluir(obj);
        }

        public AlunoView ObterPor(int id)
        {
            return _repository.Alunos.ObterPor(id).ConvertToView();
        }

        public List<AlunoView> ObterTodos()
        {
            return _repository.Alunos.ObterTodos().ConvertToView();
        }

        public void Salvar(AlunoView view)
        {
            var obj = view.Id == 0 ? new Aluno() : _repository.Alunos.ObterPor(view.Id);
            obj.NomeCompleto = view.NomeCompleto.Trim();
            obj.RA = view.RA.Trim();
            obj.DataNascimento = view.DataNascimento;
            obj.TurmaId = view.TurmaId;

            obj.Validar();

            _repository.Alunos.Salvar(obj);
        }
    }
}
