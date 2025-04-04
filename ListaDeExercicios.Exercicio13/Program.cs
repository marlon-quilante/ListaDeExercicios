﻿namespace ListaDeExercicios.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write($"\n{numero}! = {numero}");
            for (int i = numero - 1; i > 0; i--)
            {
                Console.Write($"x{i}");
                numero *= i; 
            }
            Console.Write($" = {numero}");
            Console.ReadLine();
        }
    }
}
