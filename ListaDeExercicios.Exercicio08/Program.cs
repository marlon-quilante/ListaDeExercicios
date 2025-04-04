namespace ListaDeExercicios.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b < c)
            {
                Console.Write($"\n{a} + {b} = {a+b}. Ou seja, é menor que {c}");
                Console.ReadLine();
            } else if (a + b > c)
            {
                Console.Write($"\n{a} + {b} = {a + b}. Ou seja, é maior que {c}");
                Console.ReadLine();
            }
            else
            {
                Console.Write($"\n{a} + {b} = {a + b}. Ou seja, é igual a {c}");
                Console.ReadLine();
            }
        }
    }
}
