using Myfinance_web_dotnet.Models;

namespace Myfinance_web_dotnet.Services
{
    public interface IPlanoContaService
    {
            List<PlanoContaModel> ListarRegistros();
            void Salvar(PlanoContaModel model);

            void Excluir(int id);

            PlanoContaModel RetornarRegistro(int id);

    }
}