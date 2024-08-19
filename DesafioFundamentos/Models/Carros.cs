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
}