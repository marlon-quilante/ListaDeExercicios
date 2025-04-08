namespace ListaDeExercicios.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            double tempCelsius = double.Parse(Console.ReadLine());

            double tempFahrenheit = (tempCelsius * 1.8) + 32;

            Console.Write($"\nTemperatura em graus Fahrenheit: {tempFahrenheit.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
