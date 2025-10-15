// See https://aka.ms/new-console-template for more information
using System;
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("*********** Výpis číselné řady *************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Sára Kristanová ******************");
            Console.WriteLine("************** 15.10.2025 *******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            // Vstup hodnoty do programu, ale špatně řešený
            //Console.Write("Zadejte první číslo řady: ");
            //int first = int.Parse(Console.ReadLine());

              // Zadej první číslo
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;
            while (!int.TryParse(Console.ReadLine(), out first))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
            }

            // Zadej poslední číslo
            Console.Write("Zadejte poslední číslo řady (celé číslo): ");
            int last;
            while (!int.TryParse(Console.ReadLine(), out last))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("Výpis číselné řady:");

            // Výpis čísel mezi first a last
            if (first <= last)
            {
                for (int i = first; i <= last; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                for (int i = first; i >= last; i--)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Pro opakování programu stiskněte klávesu 'a', nebo jinou pro ukončení: ");
            again = Console.ReadLine()!;
        }
 
