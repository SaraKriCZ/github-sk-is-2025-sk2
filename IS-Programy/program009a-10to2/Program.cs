using System;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** ze soustavy 10 na 2 *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Sára Kristanová ******************");
    Console.WriteLine("************** 27.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


        Console.Write("Zadejte hodnotu (přirozené číslo) - desítkové číslo: ");
        uint number10;

        while (!uint.TryParse(Console.ReadLine(), out number10))
            {
            Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu (přirozené číslo) - desítkové číslo: ");
            }
        
        uint backupNumber10 = number10;
        uint zbytek;

       uint[] myArray = new uint[32];

        uint i;
        for (i = 0; number10 > 0; i++)
        zbytek = number10 % 2;
        number10 = (number10 - zbytek) / 2;
        myArray[i] = zbytek;

        Console.WriteLine("Celá část = {0}; Zbytek = {1}", number10, zbytek);
    }

    Console.WriteLine();
    for (uint j=i-1;j>=0;j--) {
        Console.Write("{0}", myArray[j]);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a', nebo jinou pro ukončení: ");
    again = Console.ReadLine()!;
}

