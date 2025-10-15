string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("********Výpis číselné řady*************");
    Console.WriteLine("***************************************");
    Console.WriteLine("*******Sára Kristanová*****************");
    Console.WriteLine("***************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatné řešení
    //Console.Write("Zadejte první číslo řady: ")
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, ale řešený lépe
    Console.Write("Zadejte první číslo řady: ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first)) ;
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu");
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a,");
    again = Console.ReadLine();

}