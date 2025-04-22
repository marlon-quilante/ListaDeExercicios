namespace ListaDeExercicios.Exercicio01
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma caixa retangular
        //VOLUME = COMPRIMENTO * LARGURA * ALTURA
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();

            #region input de dados
            Console.Write("Digite o comprimento da caixa: ");
            caixa.comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura da caixa: ");
            caixa.largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da caixa: ");
            caixa.altura = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region processamento
            double volume = caixa.ObtemVolume();
            #endregion

            #region output do resultado
            Console.Write($"\nVolume da caixa: {volume.ToString("F2")}");
            Console.ReadLine();
            #endregion
        }
    }
}
