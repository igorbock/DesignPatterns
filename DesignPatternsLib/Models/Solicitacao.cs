namespace DesignPatternsLib.Models;

public class Solicitacao
{
    public int Id { get; set; }
    public string? Tipo { get; set; }
    public string? Entidade { get; set; }
    public string? HttpMethod { get; set; }
    public DateTime? Inicio { get; set; }
    public DateTime? Fim { get; set; }
    public bool? Concluida { get; set; }
}
