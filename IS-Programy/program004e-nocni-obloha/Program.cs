using System;
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("********* Vykreslení noční oblohy***********");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************ Sára Kristanová ***************");
            Console.WriteLine("************** 29.10.2025 *******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.Write("Zadejte šířku oblohy: ");
            int width;
            while (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte šířku oblohy: ");
            }
            
            Console.Write("Zadejte výšku oblohy: ");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte výšku oblohy: ");
            }
            
            for (int i = 0; i < height; i++)
            {
            for (int j = 0; j < width; j++)
            {
            if ((i + j) % 2 == 0)
            Console.Write("*");
            else
            Console.Write(" ");
            }
            Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Pro opakování programu stiskněte klávesu 'a', nebo jinou pro ukončení: ");
            again = Console.ReadLine()!;
        }
