using System;
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("**************** Vykreslení Z***************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************ Sára Kristanová ***************");
            Console.WriteLine("************** 29.10.2025 *******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.Write("Zadejte šířku tvaru Z: ");
            int width;
            while (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte šířku tvaru Z: ");
            }
            
            Console.Write("Zadejte výšku tvaru Z: ");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte výšku tvaru Z: ");
            }

            for (int i = 0; i < height; i++)
            {
            for (int j = 0; j < width; j++)
            {
            if (i == 0 || i == height - 1 || j == width - 1 - (i * (width - 1) / (height - 1)))
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
