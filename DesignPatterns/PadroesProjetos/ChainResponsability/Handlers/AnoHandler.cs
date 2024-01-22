namespace DesignPatterns.PadroesProjetos.ChainResponsability.Handlers;

public class AnoHandler : AbstractHandler
{
    public override object? Handle(object request)
    {
        var ano = int.Parse(request.ToString()!);
        if (ano > 2010)
            return "O ano do veículo é maior que 2010.";
        else
            return "O ano do veículo é menor que 2010.";
    }
}
