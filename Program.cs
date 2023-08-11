
using System.Diagnostics;

public class Program{
    public static void Main(string[] args){
        List<Estado> estados = new List<Estado>(){
            new Estado("Bahia","BA","Salvador"),
            new Estado("Pernambuco","PE","Recife"),
        };

        //ordenação e impressão dos valores utilizando LINQ
        estados.OrderBy(e => e.Nome)//ordenação
        .ToList()//cast para list
        .ForEach(e => Console.WriteLine(e.Nome));//loop em toda lista e print nos valores
    }
}
