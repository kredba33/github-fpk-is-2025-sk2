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
            Console.WriteLine("************** Program 004a ****************");
            Console.WriteLine("*************** Obdélník *******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Filip Patrik Kredba **********");
            Console.WriteLine("************** 30.10.2025 ******************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            // --- Vstup ---
            int a, b;
            Console.Write("Zadejte délku strany a (šířka): ");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
                Console.Write("Neplatné číslo. Zadejte kladné celé číslo: ");

            Console.Write("Zadejte délku strany b (výška): ");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
                Console.Write("Neplatné číslo. Zadejte kladné celé číslo: ");

            // --- Výpočet / výstup ---
            Console.WriteLine();
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }

            Console.WriteLine($"\nVykreslen obdélník {a}x{b}");
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
