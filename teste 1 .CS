using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (NumeroPertenceFibonacci(numero))
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool NumeroPertenceFibonacci(int n)
    {
        int a = 0, b = 1;

        // Se o número for menor que 0, não pode estar na sequência
        if (n < 0) return false;

        // Gera os números de Fibonacci até alcançar ou ultrapassar n
        while (a < n)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        // Verifica se encontramos o número
        return a == n;
    }
}