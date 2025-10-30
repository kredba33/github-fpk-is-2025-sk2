using System;

class Program
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("************** Program 004b ****************");
            Console.WriteLine("********** Pravoúhlý trojúhelník ***********");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Filip Patrik Kredba **********");
            Console.WriteLine("************** 30.10.2025 ******************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            // --- Vstup ---
            int n;
            Console.Write("Zadejte výšku trojúhelníku: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                Console.Write("Neplatné číslo. Zadejte kladné celé číslo: ");

            // --- Výstup ---
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }

            Console.WriteLine($"\nVykreslen pravoúhlý trojúhelník (výška {n})");
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
