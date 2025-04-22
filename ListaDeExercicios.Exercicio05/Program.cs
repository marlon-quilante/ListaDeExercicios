namespace ListaDeExercicios.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();

            Console.Write("Digite o salário base do vendedor: ");
            vendedor.salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas do vendedor: ");
            vendedor.totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de comissão: ");
            vendedor.percentualGanho = double.Parse(Console.ReadLine());

            double salarioTotal = vendedor.CalcularSalario();

            Console.Write($"\nSalário do vendedor: R$ {salarioTotal.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
