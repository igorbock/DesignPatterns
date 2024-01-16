namespace DesignPatterns;

public class DesignPatternsLogger
{
    private readonly ILogger _logger;

    public DesignPatternsLogger(ILogger<DesignPatternsLogger> logger)
    {
        _logger = logger;
    }

    public void DispararLog(string mensagem, bool ehUmErro = false)
    {
        var dataHoraComMensagem = string.Format("{0} - {1}", DateTime.Now.ToString("dd/MM/yyyy HH:mm"), mensagem);

        if (ehUmErro)
            _logger.LogError(dataHoraComMensagem);
        else
            _logger.LogInformation(dataHoraComMensagem);
    }
}
