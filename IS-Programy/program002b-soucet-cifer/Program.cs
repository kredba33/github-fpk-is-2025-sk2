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
            Console.WriteLine("************ Součet a součin cifer *********");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Filip Patrik Kredba **********");
            Console.WriteLine("************** 16.10.2025 ******************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.Write("Zadejte celé číslo: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
            }

            // Převod čísla na kladné a na text
            string text = Math.Abs(number).ToString();

            int soucet = 0;
            int soucin = 1;

            // Pokud je číslo 0, nastavíme součin i součet na 0
            if (text == "0")
            {
                soucet = 0;
                soucin = 0;
            }
            else
            {
                foreach (char znak in text)
                {
                    int cifra = znak - '0'; // převod znaku číslice na int
                    soucet += cifra;
                    soucin *= cifra;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Součet cifer čísla {number} je {soucet}");
            Console.WriteLine($"Součin cifer čísla {number} je {soucin}");
            Console.WriteLine();

            Console.Write("Pro opakování stiskněte a: ");
            again = Console.ReadLine();
        }
    }
}
