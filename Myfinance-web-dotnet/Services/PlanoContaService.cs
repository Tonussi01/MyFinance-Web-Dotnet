using Myfinance_web_dotnet.Models;
using MyFinance_web_dotnet.Infrastruture;
using AutoMapper;
using Myfinance_web_dotnet.Domain;

namespace Myfinance_web_dotnet.Services
{
    public class PlanoContaService : IPlanoContaService
    {
        private readonly MyFinanceDbContext _myFinanceDbContext;
        private readonly IMapper _mapper;

        public PlanoContaService(MyFinanceDbContext myFinanceDbContext, IMapper mapper)
        {
            _myFinanceDbContext = myFinanceDbContext;
            _mapper = mapper;
        }

        public void Excluir(int id)
        {
            var item = _myFinanceDbContext.PlanoConta.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _myFinanceDbContext.PlanoConta.Remove(item);
                _myFinanceDbContext.SaveChanges();
            }
        }

        public List<PlanoContaModel> ListarRegistros()
        {
            var listaPlanoConta = _myFinanceDbContext.PlanoConta.ToList();
            var lista = _mapper.Map<List<PlanoContaModel>>(listaPlanoConta);
            return lista;
        }

        public PlanoContaModel RetornarRegistro(int id)
        {
            var item = _myFinanceDbContext.PlanoConta.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<PlanoContaModel>(item);
        }

        public void Salvar(PlanoContaModel model)
        {
            var item = _mapper.Map<PlanoConta>(model);

            if (item.Id == 0)
            {
                _myFinanceDbContext.PlanoConta.Add(item);
            }
            else
            {
                var existingItem = _myFinanceDbContext.PlanoConta.FirstOrDefault(x => x.Id == item.Id);
                if (existingItem != null)
                {
                    _mapper.Map(model, existingItem); // Atualiza os dados do item existente
                    _myFinanceDbContext.PlanoConta.Update(existingItem);
                }
            }

            _myFinanceDbContext.SaveChanges();
        }
    }
}
