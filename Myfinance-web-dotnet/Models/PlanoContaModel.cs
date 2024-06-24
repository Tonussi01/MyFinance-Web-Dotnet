
using System.ComponentModel.DataAnnotations;

namespace Myfinance_web_dotnet.Models{

    public class PlanoContaModel
    {
        public int? Id{get;set;}

        [Required (ErrorMessage ="Informe a descrição do item de Plano de Conta!")]
        public string? Descricao{get; set;}

        [Required (ErrorMessage ="Informe a tipo do item de Plano de Conta!")]
        public string? Tipo{get; set; }
        
    }
}