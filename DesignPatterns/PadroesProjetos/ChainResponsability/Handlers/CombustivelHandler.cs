namespace DesignPatterns.PadroesProjetos.ChainResponsability.Handlers;

public class CombustivelHandler : AbstractHandler
{
    public override object? Handle(object request)
    {
        var combustivel = request.ToString();
        if (string.Equals(combustivel, "Diesel"))
            return "O veículo utiliza Diesel";
        else
            return "O veículo não utiliza Diesel";
    }
}
