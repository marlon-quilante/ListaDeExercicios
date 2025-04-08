namespace ListaDeExercicios.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (Math.Pow(altura, 2));

            Console.WriteLine("\nIMC: " + imc.ToString("F2"));

            if (imc < 18.5){
                Console.WriteLine("\nAbaixo do peso");
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("\nPeso normal");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("\nAcima do peso");
            }
            else
            {
                Console.WriteLine("\nObeso");
            }

            Console.ReadLine();
        }
    }
}
