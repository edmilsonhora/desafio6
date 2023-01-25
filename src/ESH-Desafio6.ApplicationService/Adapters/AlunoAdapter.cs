using ESH_Desafio6.ApplicationService.Views;
using ESH_Desafio6.DomainModel.Models;
using System.Collections.Generic;

namespace ESH_Desafio6.ApplicationService.Adapters
{
    static class AlunoAdapter
    {
        public static List<AlunoView> ConvertToView(this List<Aluno> lista)
        {
            var novaLista = new List<AlunoView>();

            foreach (var item in lista)
            {
                novaLista.Add(item.ConvertToView());
            }

            return novaLista;
        }

        public static AlunoView ConvertToView(this Aluno item)
        {
            if (item == null) return new AlunoView();

            return new AlunoView()
            {
                Id = item.Id,
                DataNascimento = item.DataNascimento,
                NomeCompleto = item.NomeCompleto,
                RA = item.RA,
                TurmaId = item.TurmaId
            };
        }
    }
}
