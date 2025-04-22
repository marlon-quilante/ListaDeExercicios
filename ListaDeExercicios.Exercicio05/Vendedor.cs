namespace ListaDeExercicios.Exercicio05
{
    internal class Vendedor
    {
        public double salarioFixo;
        public double totalVendas;
        public double percentualGanho;

        public double CalcularSalario()
        {
            double comissao = totalVendas * (percentualGanho / 100);

            double salarioTotal = (salarioFixo + comissao);

            return salarioTotal;
        }
    }
}
