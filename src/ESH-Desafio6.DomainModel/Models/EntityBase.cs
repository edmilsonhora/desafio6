using System;
using System.Text;

namespace ESH_Desafio6.DomainModel.Models
{

    public abstract class EntityBase
    {
        protected StringBuilder RegrasQuebradas = new StringBuilder();        

        public virtual void Validar()
        {
            if (RegrasQuebradas.Length > 0)
                throw new ApplicationException(RegrasQuebradas.ToString());
        }

        protected void CampoTextoObrigatorio(string nomeCampo, string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                RegrasQuebradas.Append($"O campo {nomeCampo} é obrigatorio.{Environment.NewLine}");
        }

        protected void CampoIdObrigatorio(string nomeCampo, int valor)
        {
            if (valor == 0)
                RegrasQuebradas.Append($"O campo {nomeCampo} é obrigatório.{Environment.NewLine}");
        }

        protected void DataNaoPodeEstarNoFuturo(string nomeCampo, DateTime valor)
        {
            if (valor.Date > DateTime.Now.Date)
                RegrasQuebradas.Append($"O campo {nomeCampo} não pode ser uma data futura.");
        }
    }
}
