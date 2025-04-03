namespace ListaDeExercicios.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário base do vendedor: ");
            decimal salarioBase = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas do vendedor: ");
            decimal totalVendas = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de comissão: ");
            decimal percentualComissao = decimal.Parse(Console.ReadLine());

            decimal comissao = totalVendas * (percentualComissao / 100);
            decimal salarioFinal = salarioBase + comissao;

            Console.Write($"\nSalário do vendedor: R$ {salarioFinal.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
