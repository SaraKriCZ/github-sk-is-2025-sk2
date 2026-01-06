using System;

bool hratZnovu = true; 

Console.WriteLine("--- Vítej ve hře Kámen, Nůžky, Papír! ---");

// Hlavní smyčka
while (hratZnovu)
    {
    Console.Write("\nVyber si (kamen, nuzky, papir): ");
                
    string vstupHrace = Console.ReadLine().ToLower().Trim();

    // Ověření
        if (vstupHrace != "kamen" && vstupHrace != "nuzky" && vstupHrace != "papir")
            {
            Console.WriteLine("Neplatná volba! Zkus to znovu.");
            continue; 
            }

        Random nahoda = new Random();
        int cisloPocitace = nahoda.Next(1, 4);
        string tahPocitace = "";

        switch (cisloPocitace)
                {
                case 1: tahPocitace = "kamen"; break;
                case 2: tahPocitace = "nuzky"; break;
                case 3: tahPocitace = "papir"; break;
                }

        Console.WriteLine($"Počítač vybral: {tahPocitace}");

// Vyhodnocení
        if (vstupHrace == tahPocitace)
            {
            Console.WriteLine("Je to remíza!");
            }
        else if ((vstupHrace == "kamen" && tahPocitace == "nuzky") ||
                (vstupHrace == "nuzky" && tahPocitace == "papir") ||
                (vstupHrace == "papir" && tahPocitace == "kamen"))
            {
            Console.WriteLine("Vyhrál jsi toto kolo!");
            }
        else
            {
            Console.WriteLine("Počítač vyhrál toto kolo.");
            }

// Dotaz na konec hry
        Console.WriteLine("\nChceš hrát dál? (ano/ne)");
        string odpoved = Console.ReadLine().ToLower();
                
        if (odpoved == "ne")
            {
            hratZnovu = false;
            }
    }

// Rozloučení
Console.WriteLine("Díky za hru!");
Console.ReadKey();