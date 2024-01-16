namespace DesignPatterns.Strategy;

public abstract class ContextoBase<TipoT> where TipoT : class
{
    protected Solicitacao _solicitacao;
    protected IServiceCRUD<TipoT>? _service;
    protected TipoT? _entidade;

    public ContextoBase(Solicitacao solicitacao, IServiceCRUD<TipoT> service)
    {
        _solicitacao = solicitacao;
        _service = service;
    }

    public virtual async Task<Retorno> RealizarAcaoAsync()
    {
        string json = string.Empty;
        if (_service == null)
            throw new ArgumentNullException(nameof(_service));

        switch (_solicitacao.HttpMethod)
        {
            case "GET": json = JsonSerializer.Serialize(await _service.GetAsync()); break;
            case "POST": await _service.CreateAsync(_entidade!); break;
            case "PUT": await _service.EditAsync(_entidade!); break;
            case "DELETE": await _service.DeleteAsync(_entidade!); break;
            default: throw new NotImplementedException();
        }

        return new Retorno(json);
    }
}
