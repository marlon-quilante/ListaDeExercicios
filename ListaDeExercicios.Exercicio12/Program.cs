namespace ListaDeExercicios.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int numero = 100; numero <= 200; numero++)
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
