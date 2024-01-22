 namespace DesignPatterns.PadroesProjetos.ChainResponsability;

public interface IHandler
{
    IHandler NextHandler(IHandler handler);

    object? Handle(object request);
}
