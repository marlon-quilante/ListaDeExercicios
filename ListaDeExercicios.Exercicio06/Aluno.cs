namespace ListaDeExercicios.Exercicio06
{
    internal class Aluno
    {
        public double nota1;
        public double nota2;
        
        public double ObtemMediaPonderada(double pesoNota1, double pesoNota2)
        {
            double totalMediaPonderada = ((nota1 * pesoNota1) + (nota2 * pesoNota2)) / (pesoNota1 + pesoNota2);

            return totalMediaPonderada;
        }
    }
}
