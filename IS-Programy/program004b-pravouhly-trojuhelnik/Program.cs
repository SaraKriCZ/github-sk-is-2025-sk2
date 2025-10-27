using System;
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("**** Vykreslení pravoúhlého trojuhelníku*****");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Sára Kristanová ******************");
            Console.WriteLine("************** 27.10.2025 *******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.Write("Zadejte délku strany a: ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte délku strany a znovu: ");
            }
            
            Console.Write("Zadejte délku strany b: ");
            int b;
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte délku strany b znovu: ");
            }

            // Trojúhelník - první řádek 1 hvězdička, poslední řádek 'b' hvězdiček
            for (int i = 1; i <= a; i++)
            {
            // Určíme počet hvězdiček v řádku: úměrně b
            int starsInRow = 1 + (i - 1) * (b - 1) / (a - 1);

            for (int j = 1; j <= starsInRow; j++)
            {
            Console.Write("* ");
            System.Threading.Thread.Sleep(50); // jen pro efekt, můžeš upravit
            }
            Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Pro opakování programu stiskněte klávesu 'a', nebo jinou pro ukončení: ");
            again = Console.ReadLine()!;
        }
