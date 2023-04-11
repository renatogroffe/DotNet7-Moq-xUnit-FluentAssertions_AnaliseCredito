namespace ConsultaCredito;

public enum StatusConsultaCredito
{
    Indefinido = -9,
    ParametroEnvioInvalido = -2,
    ErroComunicacao = -1,
    SemPendencias = 0,
    Inadimplente = 1
}

public class Pendencia
{
    public string? CPF { get; set; }
    public string? NomePessoa { get; set; }
    public string? NomeReclamante { get; set; }
    public string? DescricaoPendencia { get; set; }
    public DateTime DataPendencia { get; set; }
    public double VlPendencia { get; set; }
}