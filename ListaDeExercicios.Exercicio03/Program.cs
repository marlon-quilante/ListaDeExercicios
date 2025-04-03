namespace ListaDeExercicios.Exercicio03
{
    internal class Program
    {
        //Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.
        
        static void Main(string[] args)
        {
            Console.Write("Digite a quilometragem inicial do veículo: ");
            double kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem final do veículo: ");
            double kmFinal = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de combustível consumida (em litros): ");
            double qtdCombustivel = double.Parse(Console.ReadLine());

            double consumoCombustivel = (kmFinal - kmInicial) / qtdCombustivel;

            Console.Write($"\nConsumo de combustível: {consumoCombustivel.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
