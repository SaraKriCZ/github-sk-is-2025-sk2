using System;

        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("*** Generátor pseunáhodných čísel **********");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("**********Sára K.*****************");
            Console.WriteLine("************** 26.11.2025 *******************");
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

            Console.WriteLine();
            Console.WriteLine("Náhodná čísla: ");
            for (int i = 0; i < n; i++)
            {
                myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
                Console.Write("{0}; ", myRandNumbs[i]);
            }
            Console.WriteLine("\n"); // Odřádkování po výpisu náhodných čísel

            // =========================================================
            // ZDE ZAČÍNÁ ŘEŠENÍ ÚKOLU (Bubble Sort + Obrazec)
            // =========================================================

            // 1. BUBBLE SORT - SESTUPNĚ
            // Procházíme pole a prohazujeme sousedy, pokud je ten vlevo menší než ten vpravo
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Změna znaménka na < (menší než) zajistí sestupné řazení
                    if (myRandNumbs[j] < myRandNumbs[j + 1])
                    {
                        int temp = myRandNumbs[j];
                        myRandNumbs[j] = myRandNumbs[j + 1];
                        myRandNumbs[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Seřazená čísla pomocí metody Bubble sort:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}; ", myRandNumbs[i]);
            }
            Console.WriteLine("\n");


            // 2. URČENÍ DRUHÉHO NEJVĚTŠÍHO ČÍSLA
            // Protože je pole seřazené sestupně, na indexu [0] je největší číslo.
            // Hledáme první číslo, které je menší než to na indexu [0].
            
            int vyskaObrazce = 0;
            
            // Pojistka: Pokud je pole prázdné nebo má jen 1 prvek, nemůžeme hledat druhé největší
            if (n >= 2)
            {
                int prvniNejvetsi = myRandNumbs[0];
                
                for (int i = 1; i < n; i++)
                {
                    if (myRandNumbs[i] < prvniNejvetsi)
                    {
                        vyskaObrazce = myRandNumbs[i];
                        break; // Našli jsme ho, končíme cyklus
                    }
                }
                
                // Pokud jsme nenašli menší (všechna čísla jsou stejná), použijeme to největší
                if (vyskaObrazce == 0) vyskaObrazce = prvniNejvetsi;
            }
            else
            {
                // Pokud uživatel zadal jen 1 číslo, použijeme ho jako výšku
                if (n > 0) vyskaObrazce = myRandNumbs[0];
            }

            Console.WriteLine("Druhé největší číslo je {0}.", vyskaObrazce);
            Console.WriteLine("Obrazec:");


            // 3. VYKRESLENÍ OBRAZCE
            // Pokud je číslo příliš malé (třeba 0 nebo záporné), nic nekreslíme
            if (vyskaObrazce > 0)
            {
                for (int radek = 0; radek < vyskaObrazce; radek++)
                {
                    // Plné řádky jsou první dva (0, 1) a poslední dva (výška-1, výška-2)
                    if (radek < 2 || radek >= vyskaObrazce - 2)
                    {
                        // Plný řádek hvězdiček
                        for (int k = 0; k < vyskaObrazce; k++)
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        // Dutý řádek: Hvězda - mezery - Hvězda
                        Console.Write("*"); // Levý okraj
                        
                        // Mezery (šířka - 2 hvězdičky na krajích)
                        for (int m = 0; m < vyskaObrazce - 2; m++)
                        {
                            Console.Write(" ");
                        }
                        
                        // Pravý okraj (pokud je šířka > 1)
                        if (vyskaObrazce > 1) 
                        {
                             Console.Write("*");
                        }
                    }
                    Console.WriteLine(); // Odřádkování na konci řádku obrazce
                }
            }
            else 
            {
                Console.WriteLine("(Číslo je příliš malé pro vykreslení obrazce)");
            }

            // =========================================================
            // KONEC ŘEŠENÍ ÚKOLU
            // =========================================================

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Pro opakování programu stiskněte klávesu 'a', nebo jinou pro ukončení: ");
            again = Console.ReadLine()!;
        }
