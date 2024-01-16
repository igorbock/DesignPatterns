namespace DesignPatterns.Extensions;

public static class SolicitacaoExtensions
{
    public static void Iniciar(this Solicitacao solicitacao) => solicitacao.Inicio = DateTime.Now;
    public static void Finalizar(this Solicitacao solicitacao)
    {
        solicitacao.Fim = DateTime.Now;
        solicitacao.Concluida = true;
    }
}
