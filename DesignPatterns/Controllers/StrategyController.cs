namespace DesignPatterns.Controllers;

[ApiController]
[Route("[controller]", Name = "Strategy Controller")]
public class StrategyController : Controller
{
    private readonly IServiceCRUD<WeatherForecast> _weatherForecastService;
    private readonly IServiceCRUD<Carro> _carroService;
    private readonly DesignPatternsLogger _logger;

    public StrategyController(
        IServiceCRUD<WeatherForecast> serviceWeatherForecast,
        IServiceCRUD<Carro> serviceCarro,
        DesignPatternsLogger logger)
    {
        _weatherForecastService = serviceWeatherForecast;
        _carroService = serviceCarro;
        _logger = logger;
    }

    [HttpPost]
    public async Task<Retorno> Post(Solicitacao solicitacao)
    {
        _logger.DispararLog($"Solicitação iniciada ({solicitacao.Tipo}/{solicitacao.HttpMethod})...");
        try
        {
            solicitacao.Iniciar();
            switch(solicitacao.Tipo!)
            {
                case "WeatherForecast":
                    return await new WeatherForecastContexto(solicitacao, _weatherForecastService).RealizarAcaoAsync();
                case "Carro":
                    return await new CarroContexto(solicitacao, _carroService).RealizarAcaoAsync();

                default: throw new NotImplementedException();
            }
        }
        catch (Exception ex)
        {
            _logger.DispararLog($"Um erro aconteceu: {ex.Message}...");
            return new Retorno(ex);
        }
        finally
        {
            _logger.DispararLog("Solicitação finalizada...");
            solicitacao.Finalizar();
        }
    }
}
