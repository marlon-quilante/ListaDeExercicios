namespace ListaDeExercicios.Exercicio02
{
    internal class Program
    {
        //Crie um programa para calcular o volume de um Cilindro
        // V = pi * r² * a
        static void Main(string[] args)
        {
            //input de dados
            Console.Write("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            //processamento de dados
            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            //output do resultado
            Console.Write($"\nVolume do cilindro: {volume.ToString("F2")}");

            Console.ReadLine();
        }
    }
}
