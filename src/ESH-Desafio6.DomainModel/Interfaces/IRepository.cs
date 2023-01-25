namespace ESH_Desafio6.DomainModel.Interfaces
{
    public interface IRepository
    {
        IAlunoRepository Alunos { get; }
        void SaveChanges();
        void RollBack();
    }
}
