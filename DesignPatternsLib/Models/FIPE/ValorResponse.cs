﻿namespace DesignPatternsLib.Models.FIPE;

public class ValorResponse
{
    public int TipoVeiculo { get; set; }
    public string? Valor { get; set; }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public int AnoModelo { get; set; }
    public string? Combustivel { get; set; }
    public string? CodigoFipe { get; set; }
    public string? MesReferencia { get; set; }
    public char? SiglaCombustivel { get; set; }
}
