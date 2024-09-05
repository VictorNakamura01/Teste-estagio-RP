using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();

        int count = 0;

        foreach (char c in input)
        {
            if (c == 'a' || c == 'A')
            {
                count++;
            }
        }

        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) aparece {count} vezes.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não foi encontrada na string.");
        }
    }
}