namespace ListaDeExercicios.Exercicio04
{
    internal class TemperaturaCelsius
    {
        public double graus;

        public double ObtemTemperaturaEmFahrenheit()
        {
            double grausFahrenheit = ((9 * graus) + 160) / 5;

            return grausFahrenheit;
        }
    }
}
