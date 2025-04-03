namespace ListaDeExercicios.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota 1 do aluno: ");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o peso da nota 1: ");
            decimal pesoNota1 = decimal.Parse(Console.ReadLine());

            Console.Write("\nDigite a nota 2 do aluno: ");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o peso da nota 2: ");
            decimal pesoNota2 = decimal.Parse(Console.ReadLine());

            decimal mediaAluno = ((nota1 * pesoNota1) + (nota2 * pesoNota2)) / (pesoNota1 + pesoNota2);

            Console.Write($"\nMédia do aluno: {mediaAluno.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
