namespace ListaDeExercicios.Exercicio03
{
    internal class Program
    {
        //Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.
        
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();

            Console.Write("Digite a quilometragem inicial do veículo: ");
            veiculo.quilometragemInicial = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem final do veículo: ");
            veiculo.quilometragemFinal = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de combustível consumida (em litros): ");
            veiculo.consumoTotal = double.Parse(Console.ReadLine());

            double consumoMedio = veiculo.CalcularGasto();

            Console.Write($"\nConsumo de combustível: {consumoMedio.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
