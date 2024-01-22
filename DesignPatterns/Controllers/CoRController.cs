using DesignPatterns.PadroesProjetos.ChainResponsability.Handlers;
using DesignPatternsLib.Models.FIPE;

namespace DesignPatterns.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoRController : Controller
{
    private readonly HttpClient _httpClient;
    private readonly DesignPatternsLogger _logger;

    public CoRController(IHttpClientFactory httpClientFactory, DesignPatternsLogger logger)
    {
        _httpClient = httpClientFactory.CreateClient("FIPE");
        _logger = logger;
    }

    [HttpPost]
    public async Task<IEnumerable<object?>> Post(RequestFIPE request)
    {
        _logger.DispararLog("Iniciando consulta...");
        var response = await _httpClient.GetFromJsonAsync<ValorResponse>($"fipe/api/v1/carros/marcas/{request.Marca}/modelos/{request.Modelo}/anos/{request.Ano}");
        if (response == null)
            throw new Exception();

        var combustivel = new CombustivelHandler();
        var ano = new AnoHandler();
        var valor = new ValorHandler();

        combustivel.NextHandler(ano).NextHandler(valor);

        _logger.DispararLog("Encerrando consulta..");
        return new List<object?>
        {
            combustivel.Handle(response.Combustivel!),
            ano.Handle(response.AnoModelo),
            valor.Handle(response.Valor!)
        };
    }
}
