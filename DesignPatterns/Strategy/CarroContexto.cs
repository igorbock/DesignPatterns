namespace DesignPatterns.Strategy;

public class CarroContexto : ContextoBase<Carro>
{
    public CarroContexto(Solicitacao solicitacao, IServiceCRUD<Carro> service) : base(solicitacao, service)
    {
        if(string.IsNullOrEmpty(_solicitacao.Entidade) == false)
            _entidade = JsonSerializer.Deserialize<Carro>(solicitacao.Entidade!) ?? new Carro();
    }
}
