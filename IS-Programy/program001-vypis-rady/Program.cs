using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Výpis číselné řady ************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Filip Patrik Kredba ***********");
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** 2. 10. 2025 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    //Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadej první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());
    Console.WriteLine("Zadej první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadal jsi celé číslo. Zadej první číslo řady znovu: "); 
    }

    Console.WriteLine("Zadej poslední číslo řady řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadal jsi celé číslo. Zadej poslední číslo řady znovu: ");
    }

    Console.WriteLine("Zadej krok řady (celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.Write("Nezadal jsi celé číslo. Zadej diferenci znovu: ");
    }

    // Výstup zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine("Zadal jsi tyto hodnoty: ");
    Console.WriteLine("První číslo řady: {0}", first);
    Console.WriteLine("Poslední číslo řady: {0}", last);
    Console.WriteLine("Diference řady: {0}", step);
    Console.WriteLine("================================");
    Console.WriteLine("První číslo: {0}; Poslední číslo: {1}; Diference: {2}", first, last, step);
    Console.WriteLine("================================");

    // Výpis číselné řady
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine("Výpis číselné řady: ");

    int current = first;
    while(current <= last) {
        Console.WriteLine(current);
        current = current + step; // přičtení diference k aktuální vypisované hodnotě
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
}