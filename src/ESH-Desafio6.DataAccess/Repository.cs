using ESH_Desafio6.DataAccess.Repositories;
using ESH_Desafio6.DomainModel.Interfaces;
using ESH_Desafio6.DomainModel.Models;

namespace ESH_Desafio6.DataAccess
{
    public class Repository : IRepository
    {
       private DdDataContext _context;

        public Repository()
        {
            _context = new DdDataContext();
        }

        private IAlunoRepository _alunos;

        public IAlunoRepository Alunos => _alunos ?? (_alunos = new AlunoRepository(_context));

        public void RollBack()
        {
            _alunos = null;
            _context = new DdDataContext();
        }

        public void SaveChanges()
        {
            _context.SubmitChanges();
        }
    }
}
