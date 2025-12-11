using System;
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("*** Generátor pseunáhodných čísel **********");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********** Sára Kristanová *****************");
            Console.WriteLine("************** 06.11.2025 *******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

        Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
             while (!int.TryParse(Console.ReadLine(), out n))
            {
            Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }
            
        Console.Write("Zadejte dolní mez (celé číslo): ");
            int lowerBound;
            while (!int.TryParse(Console.ReadLine(), out lowerBound))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

        Console.Write("Zadejte horní (celé číslo): ");
            int upperBound;
            while (!int.TryParse(Console.ReadLine(), out upperBound))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================");
    Console.WriteLine();

    //deklarace pole (array)
    int[] myRandNumbs = new int[n];

    //příprava pro využití třídy random
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(15);

    //kladná, záporná, nuly
    int negativeNumbs = 0;
    int positiveNumbs = 0;
    int zeros = 0;

    //sudá, lichá
    int evenNumbs = 0;
    int oddNumbs = 0;

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write("{0}; ", myRandNumbs[i]);

        /*
        Takhle ne!!!
        if (myRandNumbs[i] > 0)
            positiveNumbs++;
        if (myRandNumbs[i] < 0)
            negativeNumbs++;
        if (myRandNumbs[i] == 0)
            zeros++;
        */

    //kladná, záporná, nula
        if (myRandNumbs[i] > 0)
            positiveNumbs++;
        else if (myRandNumbs[i] > 0)
            negativeNumbs++;
        else zeros++;
    //lichá sudá
        if (myRandNumbs[i] % 2 == 0)
            evenNumbs++;
        else oddNumbs++;
    }

    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine("Počet kladných: {0}", positiveNumbs);
    Console.WriteLine("Počet záporných: {0}", negativeNumbs);
    Console.WriteLine("Počet nul: {0}", zeros);
    Console.WriteLine("================================");
    Console.WriteLine("Počet sudých: {0}", evenNumbs);
    Console.WriteLine("Počet lichých: {0}", oddNumbs);
    Console.WriteLine("================================");
    Console.WriteLine();

    Console.WriteLine();
            Console.WriteLine();
            Console.Write("Pro opakování programu stiskněte klávesu 'a', nebo jinou pro ukončení: ");
            again = Console.ReadLine()!;
        }
