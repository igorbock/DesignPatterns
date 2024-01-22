namespace DesignPatterns.PadroesProjetos.ChainResponsability.Handlers;

public class ValorHandler : AbstractHandler
{
    public override object? Handle(object request)
    {
        var valor = double.Parse(request.ToString()!.Replace("R$", string.Empty).Replace(".", string.Empty).Replace(',', '.').Trim());
        if (valor > 50000)
            return "O valor do veículo é maior que R$50.000,00";
        else
            return "O valor do veículo é menor que R$50.000,00";
    }
}
