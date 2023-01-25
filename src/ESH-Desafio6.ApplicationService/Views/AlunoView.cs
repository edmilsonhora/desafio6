using System;
using System.ComponentModel.DataAnnotations;

namespace ESH_Desafio6.ApplicationService.Views
{
    public class AlunoView : ViewBase
    {   
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Campo Data Nascimento é obrigatório")]             
        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo Nome Completo é obrigatório")]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Campo RA é obrigatório")]
        [Display(Name = "RA")]
        public string RA { get; set; }
        
        [Range(1,99999, ErrorMessage = "Campo TurmaId obrigatório")]
        [Display(Name = "TurmaId")]
        public int TurmaId { get; set; }
    }
}
