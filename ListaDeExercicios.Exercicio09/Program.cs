namespace ListaDeExercicios.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int b = int.Parse(Console.ReadLine());
            while (b == a)
            {
                Console.Write("Digite um segundo valor diferente do primeiro: ");
                b = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o terceiro valor: ");
            int c = int.Parse(Console.ReadLine());
            while (c == a || c == b)
            {
                Console.Write("Digite um terceiro valor diferente dos outros dois: ");
                c = int.Parse(Console.ReadLine());
            }

            if (a < b && b < c)
            {
                Console.WriteLine();
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            else if (a < b && c > b)
            {
                Console.WriteLine();
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else if (a < b && c < b && c > a)
            {
                Console.WriteLine();
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
            else if (a < b && c < b && c < a)
            {
                Console.WriteLine();
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else if (a > b && c < b)
            {
                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else if (a > b && c > b && c < a)
            {
                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
        }
    }
}
