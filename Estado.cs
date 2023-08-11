public class Estado
{
    public string? Nome { get; set; }
    public string? Sigla { get; set; }
    public string? Capital { get; set; }

    public Estado() { }
    public Estado(string Nome, string Sigla, string Capital)
    {
        this.Nome = Nome;
        this.Sigla = Sigla;
        this.Capital = Capital;
    }
}