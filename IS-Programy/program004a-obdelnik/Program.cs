using System;
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("*********** Vykreslení obdelníku*************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Sára Kristanová ******************");
            Console.WriteLine("************** 23.10.2025 *******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.Write("Zadejte šířku obdelníku: ");
            int width;
            while (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte šířku obdelníku znovu: ");
            }
            
            Console.Write("Zadejte výšku obdelníku: ");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte výšku obdelníku znovu: ");
            }

            for(int i = 1; i <= height; i++) //i+1 nejdříve se vypisují řádky a pak až sloupce
            {
                for(int j = 1; j <= width; j++)
                {
                Console.Write("* ");
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(200));
                }
            Console.WriteLine();
            }




            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Pro opakování programu stiskněte klávesu 'a', nebo jinou pro ukončení: ");
            again = Console.ReadLine()!;
        }
