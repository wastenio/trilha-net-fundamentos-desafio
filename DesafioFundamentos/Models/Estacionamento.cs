namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            // Implentado o codigo que pede a placa do veiculo ao usuario
            string placa = Console.ReadLine();
            // Verifica se a placa que o usuario digitou ja esta cadastrada no sistema, caso nao, ele adiciona a nova placa.
            if (veiculos.Any(v => v.Equals(placa.ToUpper())))
            {
                Console.WriteLine("Veiculo já cadastrado");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veiculo cadastrado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // int horas = 0;
                // decimal valorTotal = 0; 
                //Realiza a conversão do valor digitado pelo usuario
                int horas = Convert.ToInt32(Console.ReadLine());
                //Realiza o calculo do preco inicio com preço por hora e multiplica pela quantidade de tempo estacionado.
                decimal valorTotal = precoInicial + precoPorHora * horas;
                //Realiza a remoção da placa do veiculo do cadastro do sistema.
                veiculos.Remove(placa.ToUpper());

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
                //Percorrendo a lista de veiculos e armazenando a lista na variavel v.
                foreach (var v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
