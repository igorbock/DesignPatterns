namespace DesignPatterns.Services;

public class CarroService : IServiceCRUD<Carro>
{
    private IList<Carro>? _carros;

    public Task CreateAsync(Carro entidade)
    {
        if (_carros == null)
            _carros = new List<Carro>();

        _carros.Add(entidade);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Carro entidade) => throw new NotImplementedException();

    public Task EditAsync(Carro entidade) => throw new NotImplementedException();

    public Task<IEnumerable<Carro>> GetAsync() => Task.FromResult(_carros ?? Enumerable.Empty<Carro>());
}
