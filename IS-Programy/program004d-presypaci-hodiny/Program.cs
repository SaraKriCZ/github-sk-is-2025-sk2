using System;
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("******** Vykreslení Přesýpacích hodin********");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************ Sára Kristanová ***************");
            Console.WriteLine("************** 29.10.2025 *******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine();
            
            Console.Write("Zadejte výšku přesýpacích hodin - liché čislo: ");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height) || height < 3 || height % 2 == 0)
            {
                Console.Write("Nezadali jste celé nebo liché číslo. Zadejte výšku přesýpacích hodin: ");
            }

            int half = height / 2;

            for (int i = 0; i < height; i++)
            {
            // Počet mezer a hvězdiček
            int spaces = i <= half ? i : height - 1 - i;
            int stars = height - 2 * spaces;

            for (int j = 0; j < spaces; j++)
            Console.Write(" ");
            for (int j = 0; j < stars; j++)
            Console.Write("*");

            Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Pro opakování programu stiskněte klávesu 'a', nebo jinou pro ukončení: ");
            again = Console.ReadLine()!;
        }
