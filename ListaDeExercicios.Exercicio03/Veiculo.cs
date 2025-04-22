namespace ListaDeExercicios.Exercicio03
{
    internal class Veiculo
    {
        public double quilometragemInicial;
        public double quilometragemFinal;
        public double consumoTotal;

        public double CalcularGasto()
        {
            double distanciaPercorrida = quilometragemFinal - quilometragemInicial;

            double consumoMedio = distanciaPercorrida / consumoTotal;

            return consumoMedio;
        }
    }
}
