using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("************** Bubble Sort ****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*********** Sára Kristanová ***************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    // Algoritmus Bubble sort

    Stopwatch myStopwatch = new Stopwatch();

    int compare = 0; //počet porovnávání
    int change = 0; //počet výměn

    
    myStopwatch.Start();
    for (int i = 0; i < n - 1; i++) //-1 zapbraňuje přetečení
    {
        for (int j = 0; j < n - i - 1; j++) //tento cyklus musí zajistit porovnávání dvou sousedních hodnot
                                            //musí dále zajistit aby se zmenšoval počet porovnaných hodnot, bez -i by projíždel i již zkontrolovanou část
        {
            compare++;
            if (myRandNumbs[j] < myRandNumbs[j + 1]) //znamínko > ovlivňuje směr
            {
                int tmp = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = tmp;
                change++;
            }
            //nebo tady compare++;
        }
    }
    myStopwatch.Stop();

    // Výpis seřazených čísel
    Console.WriteLine();
    Console.WriteLine("================================");    
    Console.WriteLine();
    Console.WriteLine("Seřazená čísla: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    Console.WriteLine();
    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet výměn: {change}");
    Console.WriteLine("Čas potřebný na seřazení čísel: {0}", myStopwatch.Elapsed);

    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu 'a', nebo jinou pro ukončení: ");
    again = Console.ReadLine()!;

}
