namespace ListaDeExercicios.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite a nota 1 do aluno: ");
            aluno.nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da nota 1: ");
            double pesoNota1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite a nota 2 do aluno: ");
            aluno.nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da nota 2: ");
            double pesoNota2 = double.Parse(Console.ReadLine());

            double mediaAluno = aluno.ObtemMediaPonderada(pesoNota1, pesoNota2);

            Console.Write($"\nMédia do aluno: {mediaAluno.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
