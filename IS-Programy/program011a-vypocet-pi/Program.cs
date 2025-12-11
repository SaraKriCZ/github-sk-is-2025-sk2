using System;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpočet PI *******");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Sára Kristanová ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    Console.Write("Zadejte přesnost (reálné číslo - menší než 1): ");
    double presnost;
    while(!double.TryParse(Console.ReadLine(), out presnost)) {
        Console.Write("Nezadali jste reálné číslo, zadejte přesnost znovu: ");
    }

    double i = 1;
    double znamenko = 1;
    double piCtvrt = 1;

    while((1/i)>=presnost) {
        //přičítá 2
        i = i + 2;
        // mění znaménka
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko * 1/i;
        //1+1*-1/3= 4/3 (1, 1/3), 1+1*+1/5= 6/5 (1, 1/5)

    //výpis cyklu - není nustností
        if(znamenko==1) {
            Console.WriteLine("Zlomek: +1/{0}; aktuální hodnota PI = {1}", i, 4 * piCtvrt);
        }
        else {
            Console.WriteLine("Zlomek: -1/{0}; aktuální hodnota PI = {1}", i, 4 * piCtvrt);
        }
    }


    Console.WriteLine("\n\n Hodnota čísla PI = {0}", 4 * piCtvrt);
    //Console.WriteLine("\n\n Hodnota čísla PI = {0:f4}", 4 * piCtvrt);
    //f4 - zobrazí jen 4 desetinná místa


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}
