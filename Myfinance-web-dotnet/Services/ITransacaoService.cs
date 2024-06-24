using Microsoft.AspNetCore.Mvc.Rendering;

using Myfinance_web_dotnet.Models;

namespace Myfinance_web_dotnet.Services
{
    public interface ITransacaoService
    {
            List<TransacaoModel> ListarRegistros();
            void Salvar(TransacaoModel model);

            void Excluir(int id);

            TransacaoModel RetornarRegistro(int id);

            public IEnumerable<SelectListItem>? Transacao{get; set;}

    }
}