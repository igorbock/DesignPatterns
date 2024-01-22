namespace DesignPatternsLib.Models.FIPE;

public record RequestFIPE
{
    public int Marca { get; set; }
    public int Modelo { get; set; }
    public string? Ano { get; set; }
}
