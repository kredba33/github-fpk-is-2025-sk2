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

            // --- Vstup ---
            Console.Write("Zadejte velikost prvního obrazce (L-tvar): ");
            int n1 = ReadSize(3);
            Console.Write("Zadejte velikost druhého obrazce (diagonála): ");
            int n2 = ReadSize(3);
            Console.Write("Zadejte velikost třetího obrazce (kruh): ");
            int n3 = ReadSize(5);

            // --- Výstup ---
            Console.WriteLine("\nvykreslen první obrazec");
            DrawLShape(n1);

            Console.WriteLine("\nvykreslen druhý obrazec");
            DrawDiagonal(n2);

            Console.WriteLine("\nvykreslen třetí obrazec");
            DrawCircle(n3);

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }

    static int ReadSize(int min)
    {
        int val;
        while (!int.TryParse(Console.ReadLine(), out val) || val < min)
            Console.Write($"Neplatné číslo. Zadejte celé číslo >= {min}: ");
        return val;
    }

    static void DrawLShape(int n)
    {
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
                Console.Write((r == n - 1 || c == 0) ? "* " : "  ");
            Console.WriteLine();
        }
    }

    static void DrawDiagonal(int n)
    {
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
                Console.Write((r == c) ? "* " : "  ");
            Console.WriteLine();
        }
    }

    static void DrawCircle(int n)
    {
        double radius = (n - 1) / 2.0;
        double center = radius;
        double tolerance = 0.6;

        for (int y = 0; y < n; y++)
        {
            for (int x = 0; x < n; x++)
            {
                double dist = Math.Sqrt(Math.Pow(x - center, 2) + Math.Pow(y - center, 2));
                Console.Write(Math.Abs(dist - radius) <= tolerance ? "* " : "  ");
            }
            Console.WriteLine();
        }
    }
}
