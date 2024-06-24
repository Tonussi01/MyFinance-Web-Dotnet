using Microsoft.AspNetCore.Mvc;
using Myfinance_web_dotnet.Models;
using Myfinance_web_dotnet.Services;
using AutoMapper;
using MyFinance_web_dotnet.Infrastruture;

[Route("[controller]")]
public class PlanoContaController : Controller
{
    private readonly IMapper _mapper;
    private readonly ILogger<PlanoContaController> _logger;
    private readonly IPlanoContaService _planoContaService;
    private readonly MyFinanceDbContext _myFinanceDbContext;

    public PlanoContaController(
        ILogger<PlanoContaController> logger,
        IPlanoContaService planoContaService,
        MyFinanceDbContext myFinanceDbContext,
        IMapper mapper)
    {
        _logger = logger;
        _myFinanceDbContext = myFinanceDbContext;
        _mapper = mapper;
        _planoContaService = planoContaService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var listaPlanoConta = _planoContaService.ListarRegistros();
        var lista = _mapper.Map<IEnumerable<PlanoContaModel>>(listaPlanoConta);
        ViewBag.ListaPlanoConta = lista;
        return View();
    }

    [HttpGet]
    [Route("Cadastro")]
    [Route("Cadastro/{id?}")]
    public IActionResult Cadastro(int? id)
    {
        if (id.HasValue)
        {
            var registro = _planoContaService.RetornarRegistro(id.Value);
            if (registro != null)
            {
                return View(registro); // Renderiza a view "Cadastro" com o modelo para edição
            }
        }
        return View(new PlanoContaModel()); // Renderiza a view "Cadastro" para novo cadastro
    }

    [HttpPost]
    [Route("Salvar")]
    [ValidateAntiForgeryToken]
    public IActionResult Salvar(PlanoContaModel model)
    {
        if (ModelState.IsValid)
        {
            _planoContaService.Salvar(model);
            return RedirectToAction("Index");
        }
        return View("Cadastro", model); // Retorna para a view "Cadastro" com os dados do modelo em caso de erro de validação
    }

    [HttpGet]
    [Route("Excluir/{id}")]
    public IActionResult Excluir(int id)
    {
        _planoContaService.Excluir(id);
        return RedirectToAction("Index");
    }
}
