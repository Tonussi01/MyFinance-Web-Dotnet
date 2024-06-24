using MyFinance_web_dotnet.Infrastruture;
using Myfinance_web_dotnet.Models;
using AutoMapper;
using Myfinance_web_dotnet.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Myfinance_web_dotnet.Services
{
    public class TransacaoService : ITransacaoService
    {

        private readonly MyFinanceDbContext _myFinanceDbContext;

        private readonly IMapper _mapper;

        public TransacaoService(
            MyFinanceDbContext myFinanceDbContext,
            IMapper mapper)
        {
            _myFinanceDbContext = myFinanceDbContext;
            _mapper = mapper;
        }

        public IEnumerable<SelectListItem>? Transacao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Excluir(int id)
        {
            var item = _myFinanceDbContext.Transacao.Where(x => x.Id == id).First();
            _myFinanceDbContext.Attach(item);
            _myFinanceDbContext.Remove(item);
            _myFinanceDbContext.SaveChanges();

        }

        public List<TransacaoModel> ListarRegistros()
        {
            var Listatransacao = _myFinanceDbContext.Transacao.Include(x => x.PlanoConta).ToList();
            var lista = _mapper.Map<List<TransacaoModel>>(Listatransacao);
            return lista;
        }

        public TransacaoModel RetornarRegistro(int id)
        {
            var item = _myFinanceDbContext.Transacao.Where(x => x.Id == id).First();
            var registro = _mapper.Map<TransacaoModel>(item);
            return registro;
        }

        public void Salvar(TransacaoModel model)
        {
            var dbSet = _myFinanceDbContext.Transacao;
            var item = _mapper.Map<Transacao>(model);

            if (item.Id == 0)
            {
                dbSet.Add(item);
            }
            else
            {
                dbSet.Attach(item);
                _myFinanceDbContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            _myFinanceDbContext.SaveChanges();
        }
    }

}

