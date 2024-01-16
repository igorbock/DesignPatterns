namespace DesignPatterns.Services;

public class WeatherForecastService : IServiceCRUD<WeatherForecast>
{
    private static readonly string[] Summaries = [ "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" ];

    public Task CreateAsync(WeatherForecast entidade) => throw new NotImplementedException();

    public Task DeleteAsync(WeatherForecast entidade) => throw new NotImplementedException();

    public Task EditAsync(WeatherForecast entidade) => throw new NotImplementedException();

    public Task<IEnumerable<WeatherForecast>> GetAsync() => Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
    {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    }));
}
