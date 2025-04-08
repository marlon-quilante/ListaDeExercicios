namespace ListaDeExercicios.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            int[] aux = new int[numero];
            int numeroFibonacci = 0;

            for (int i = 0; i < numero; i++)
            {
                if (i > 1)
                {
                    if (numeroFibonacci >= numero)
                    {
                        break;
                    }

                    aux[i] = i;
                    numeroFibonacci = aux[i - 1] + aux[i - 2];
                    Console.WriteLine(numeroFibonacci);
                    aux[i] = numeroFibonacci;
                }
                else
                {
                    if (numeroFibonacci >= numero)
                    {
                        break;
                    }

                    aux[i] = i;
                    numeroFibonacci = aux[i];
                    Console.WriteLine(numeroFibonacci);
                    aux[i] = numeroFibonacci;
                }
            }
            Console.ReadLine();
        }
    }
}
