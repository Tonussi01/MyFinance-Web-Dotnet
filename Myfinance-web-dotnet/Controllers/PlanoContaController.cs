using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFinance_web_dotnet.Infrastruture;
using Myfinance_web_dotnet.Models;
using AutoMapper;

public class PlanoContaController : Controller
{
    private readonly IMapper _mapper;
    private readonly ILogger<PlanoContaController> _logger;
    private readonly MyFinanceDbContext _myFinanceDbContext;

    public PlanoContaController(
        ILogger<PlanoContaController> logger,
        MyFinanceDbContext myFinanceDbContext,
        IMapper mapper)
    {
        _logger = logger;
        _myFinanceDbContext = myFinanceDbContext;
        _mapper = mapper;
    }

    public IActionResult Index()
    {
        
        var listaPlanoConta = _myFinanceDbContext.PlanoConta.ToList();
        var lista = _mapper.Map<IEnumerable<PlanoContaModel>>(listaPlanoConta);    
        ViewBag.ListaPlanoConta = lista;
        return View();
    }
}
