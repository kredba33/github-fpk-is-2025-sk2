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
    Console.WriteLine("Zadej první číslo řady (celé číslo): ")
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadal jsi celé číslo. Zadej první číslo řady znovu: "); 
    }







    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}