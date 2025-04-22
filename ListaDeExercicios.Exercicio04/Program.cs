namespace ListaDeExercicios.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperaturaCelsius tempCelsius = new TemperaturaCelsius();

            Console.Write("Digite a temperatura em graus Celsius: ");
            tempCelsius.graus = double.Parse(Console.ReadLine());

            double grausFahrenheit = tempCelsius.ObtemTemperaturaEmFahrenheit();

            Console.Write($"\nTemperatura em graus Fahrenheit: {grausFahrenheit.ToString("F2")} ºF");
            Console.ReadLine();
        }
    }
}
