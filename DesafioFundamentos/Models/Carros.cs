namespace DesafioFundamentos.Models;

public class Carros
{
    public string Placa { get; set; }
    public DateTime Entrada { get; set; }
    public int HorasEstacionado { get; set; }
    public int MinutosEstacionado { get; set; }
    
    public Carros(string placa)
    {
        Placa = placa;
        Entrada = DateTime.Now;
    }
    
    private void AtualizaTempo()
    {
        // Calcula o tempo que o carro ficou estacionado.
        // Para que o preço final não fique baixo, vou fazer
        // com que os segundos sejam representados como minutos
        // e os minutos como horas
        HorasEstacionado = (DateTime.Now - Entrada).Minutes;
        MinutosEstacionado = (DateTime.Now - Entrada).Seconds;
    }

    public void MostraTempoEstacionado()
    {
        AtualizaTempo();
        Console.WriteLine($"{Placa}\t{HorasEstacionado:D2}:{MinutosEstacionado:D2}");
    }
    
    public (string, decimal) ProcessaSaida(decimal precoInicial, decimal precoPorHora)
    {
        AtualizaTempo();
        decimal horas = HorasEstacionado + (MinutosEstacionado / 60);
        return ($"{HorasEstacionado}:{MinutosEstacionado}", precoInicial + (horas * precoPorHora));
    }
}