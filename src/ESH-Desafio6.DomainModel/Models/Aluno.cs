using ESH_Desafio6.DomainModel.Interfaces;

namespace ESH_Desafio6.DomainModel.Models
{
    public partial class Aluno: EntityBase, IEntityBase
    {

        public override void Validar()
        {
            CampoTextoObrigatorio("Nome Completo", NomeCompleto);
            CampoTextoObrigatorio("RA", RA);
            DataNaoPodeEstarNoFuturo("Data Nascimento", DataNascimento);
            CampoIdObrigatorio("TurmaId", TurmaId);

            base.Validar();
        }
    }
}
