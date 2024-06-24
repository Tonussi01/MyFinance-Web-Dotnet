
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Myfinance_web_dotnet.Models{

    public class TransacaoModel
    {
        public int? Id {get;set; }
        public string? Historico { get; set; }
        public DateTime Data { get; set; }
        
         [Required (ErrorMessage ="Informe o valor da Transação!")]
         [Range(0.01, 99999999999.99, ErrorMessage ="O valor deve ser menor que 0")]
        public decimal Valor { get; set; }
        public decimal PlanoContaId { get; set; }
        public PlanoContaModel? ItemPlanoConta { get; set; }

        public IEnumerable<SelectListItem>? PlanoContas { get; set; }


        
    }
}