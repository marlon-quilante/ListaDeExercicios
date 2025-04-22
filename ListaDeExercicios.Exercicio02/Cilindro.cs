namespace ListaDeExercicios.Exercicio02
{
    internal class Cilindro
    {

        public double raio;
        public double altura;

        public double ObtemVolume()
        {
            double areaB = (Math.PI * raio * raio);

            double volume = areaB * altura;

            return volume;
        }
    }
}
