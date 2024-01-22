namespace DesignPatterns.PadroesProjetos.ChainResponsability;

public class AbstractHandler : IHandler
{
    private IHandler? _nextHandler;

    public virtual object? Handle(object request)
    {
        if (_nextHandler != null)
            return _nextHandler.Handle(request);
        else
            return null;
    }

    public IHandler NextHandler(IHandler handler)
    {
        _nextHandler = handler;

        return _nextHandler;
    }
}
