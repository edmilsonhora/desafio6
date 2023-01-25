using ESH_Desafio6.DomainModel.Interfaces;
using ESH_Desafio6.DomainModel.Models;

namespace ESH_Desafio6.DataAccess.Repositories
{
    internal class AlunoRepository : AbstractRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(DdDataContext context) : base(context)
        {
        }
    }
}
