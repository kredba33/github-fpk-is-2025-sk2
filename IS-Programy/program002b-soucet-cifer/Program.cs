using System;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Součet číslic - varianta B ******");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jan Ulrich *******************");
    Console.WriteLine("************** 16.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Načteme číslo jako text, abychom podpořili velmi velká čísla
    Console.Write("Zadejte číslo (může obsahovat znaménko + nebo -): ");
    string? input = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(input))
    {
        Console.Write("Nezadali jste číslo. Zadejte ho znovu: ");
        input = Console.ReadLine();
    }

    // Odebereme bílé znaky
    input = input!.Trim();

    // Pokud má vstup znaménko na začátku, odstraníme ho
    if (input.StartsWith("+") || input.StartsWith("-"))
    {
        input = input.Substring(1);
    }

    long sum = 0;
    bool anyDigit = false;
    foreach (char c in input)
    {
        if (char.IsDigit(c))
        {
            anyDigit = true;
            sum += c - '0';
        }
        else
        {
            // pokud narazíme na nepovolený znak, upozorníme a požádáme o nové zadání
            Console.WriteLine("Vstup obsahuje nepovolené znaky ('{0}'). Prosím zadejte pouze číslo.", c);
            sum = 0;
            anyDigit = false;
            break;
        }
    }

    if (!anyDigit)
    {
        Console.WriteLine("Vstup neobsahuje žádnou číslici. Zkusme to znovu.");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("Zadali jste: {0}", input);
        Console.WriteLine("Součet číslic: {0}", sum);
        Console.WriteLine("================================");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování stiskněte 'a', pro ukončení jinou klávesu");
    again = Console.ReadLine() ?? "";
}
