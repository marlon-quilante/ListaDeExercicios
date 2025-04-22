namespace ListaDeExercicios.Exercicio01
{
    internal class CaixaRetangular
    {
        public double altura;
        public double largura;
        public double comprimento;

        public double ObtemVolume()
        {
            double volume = altura * largura * comprimento;
            
            return volume;
        }
    }
}
