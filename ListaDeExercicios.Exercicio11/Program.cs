namespace ListaDeExercicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Este número é par!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Este número é ímpar!");
                Console.ReadLine();
            }
        }
    }
}
