
using System.Diagnostics;

public class Program{
    public static void Main(string[] args){
        List<Estado> estados = new List<Estado>(){
            new Estado("Bahia","BA","Salvador"),
            new Estado("Pernambuco","PE","Recife"),
        };

        estados.OrderBy(e => e.Nome)
        .ToList()
        .ForEach(e => Console.WriteLine(e.Nome));
    }
}
