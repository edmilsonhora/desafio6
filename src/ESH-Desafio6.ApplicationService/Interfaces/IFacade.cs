namespace ESH_Desafio6.ApplicationService.Interfaces
{
    public interface IFacade
    {
        IAlunoFacade Alunos { get; }
        void SaveChanges();
        void Rollback();
    }


}
