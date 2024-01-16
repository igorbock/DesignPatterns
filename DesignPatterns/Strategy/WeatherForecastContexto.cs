namespace DesignPatterns.Strategy;

public class WeatherForecastContexto : ContextoBase<WeatherForecast>
{
    public WeatherForecastContexto(Solicitacao solicitacao, IServiceCRUD<WeatherForecast> service) : base(solicitacao, service)
    {
        if (string.IsNullOrEmpty(_solicitacao.Entidade) == false)
            _entidade = JsonSerializer.Deserialize<WeatherForecast>(solicitacao.Entidade!) ?? new WeatherForecast();
    }
}
