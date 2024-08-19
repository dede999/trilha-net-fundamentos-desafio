namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Carros> veiculos = new List<Carros>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        
        public static string PegaPlaca(string motivo)
        {
            Console.WriteLine($"Digite a placa do veículo para {motivo}:");
            return Console.ReadLine();
        }

        public void AdicionarVeiculo()
        {
            var carro = new Carros(PegaPlaca("adicionar"));
            veiculos.Add(carro);
        }

        public void RemoverVeiculo()
        {
            string placa = PegaPlaca("remover");

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.Placa.ToUpper() == placa!.ToUpper()))
            {
                var carro = veiculos.First(x => x.Placa.ToUpper() == placa.ToUpper());
                var (tempo, valorTotal) = carro.ProcessaSaida(precoInicial, precoPorHora);
                Console.WriteLine("O veículo permaneceu estacionado por: " + tempo);

                veiculos.Remove(carro);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    veiculo.MostraTempoEstacionado();
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
