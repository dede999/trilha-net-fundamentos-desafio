namespace DesafioFundamentos.Models;

public class Carros
{
    public string Placa { get; set; }
    public DateTime Entrada { get; set; }
    
    public Carros(string placa)
    {
        Placa = placa;
        Entrada = DateTime.Now;
    }
    
    public void MostraTempoEstacionado()
    {
        // Calcula o tempo que o carro ficou estacionado.
        // Para que o preço final não fique baixo, vou fazer
        // com que os segundos sejam representados como minutos
        // e os minutos como horas
        var minutos = (DateTime.Now - Entrada).Seconds;
        var horas = (DateTime.Now - Entrada).Minutes;
        Console.WriteLine($"{Placa}\t{horas}:{minutos}");
    }
}