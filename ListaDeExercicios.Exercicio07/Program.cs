namespace ListaDeExercicios.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            bool numeroPrimo = true;

            for (int i = 1; i <= numero; i++)
            {
                int resultado = numero % i;
                if (resultado == 0 && i != 1 && i != numero)
                {
                    numeroPrimo = false;
                }
            }

            if (numeroPrimo == true)
            {
                Console.WriteLine($"\n{numero} é um número primo!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"\n{numero} não é um número primo!");
                Console.ReadLine();
            }
        }
    }
}
