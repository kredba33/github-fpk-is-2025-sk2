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
            Console.WriteLine("************** Program 004c ****************");
            Console.WriteLine("*************** Různé obrazce **************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Filip Patrik Kredba **********");
            Console.WriteLine("************** 30.10.2025 ******************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.Write("Jaký obrazec chceš vykreslit (A - šachovnice, B - kosočtverec (obrys), C - písmeno N): ");
            char volba = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Zadej velikost (celé číslo >= 2): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
            {
                Console.WriteLine("Neplatná velikost. Zadej celé číslo >= 2.");
            }
            else
            {
                Console.WriteLine();

                switch (volba)
                {
                    case 'A':
                        Console.WriteLine("vykreslen první obrazec - šachovnice");
                        VykresliSachovnici(n);
                        break;
                    case 'B':
                        Console.WriteLine("vykreslen druhý obrazec - kosočtverec (obrys)");
                        VykresliKosoctverecObrys(n);
                        break;
                    case 'C':
                        Console.WriteLine("vykreslen třetí obrazec - písmeno N");
                        VykresliPismenoN(n);
                        break;
                    default:
                        Console.WriteLine("Neplatná volba. Zvol A, B nebo C.");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }

    // A: šachovnice hvězdiček (střídání)
    static void VykresliSachovnici(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i + j) % 2 == 0)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    // B: kosočtverec - pouze obrys
    static void VykresliKosoctverecObrys(int n)
    {
        int mid = n / 2;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(i - mid) + Math.Abs(j - mid) == mid)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    // C: písmeno N
    static void VykresliPismenoN(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || j == n - 1 || j == i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
