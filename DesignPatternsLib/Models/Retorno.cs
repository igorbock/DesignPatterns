namespace DesignPatternsLib.Models;

public class Retorno
{
    public Retorno(Exception exception)
    {
        Exception = exception.ToString();
        Sucesso = false;
    }

    public Retorno(string json)
    {
        Resultado = json;
        Sucesso = true;
    }

    public bool? Sucesso { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Exception { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Resultado { get; set; }
}
