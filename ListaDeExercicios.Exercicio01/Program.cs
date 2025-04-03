namespace ListaDeExercicios.Exercicio01
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma caixa retangular
        //VOLUME = COMPRIMENTO * LARGURA * ALTURA
        static void Main(string[] args)
        {
            #region input de dados
            Console.Write("Digite o comprimento da caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a largura da caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a altura da caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());
            #endregion

            #region processamento
            decimal volume = comprimento * largura * altura;
            #endregion

            #region output do resultado
            Console.Write($"Volume da caixa: {volume}");
            Console.ReadLine();
            #endregion
        }
    }
}
