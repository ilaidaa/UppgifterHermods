using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgifterHermods
{
    internal class Bus
    {
        // Lista för att lagra passagerarnas ålder
        public List<int> passengers = new List<int>();

        // Huvudmetod som kör programmet
        public void Run()
        {
            Console.WriteLine("Välkommen till Buss-simulatorn!");
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMENY");
                Console.WriteLine("1. Lägg till passagerare");
                Console.WriteLine("2. Visa alla passagerare");
                Console.WriteLine("3. Visa genomsnittlig ålder");
                Console.WriteLine("4. Hitta passagerare efter ålder");
                Console.WriteLine("5. Sortera passagerarna efter ålder");
                Console.WriteLine("6. Avsluta");
                Console.Write("Välj ett alternativ (1-6): ");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Fel inmatning. Försök igen");
                    continue;     
                }

                switch (choice)
                {
                    case 1:
                        AddPassenger();
                        break;

                    case 2:
                        PrintBuss();
                        break;

                    case 3:
                        CalcAverageAge();
                        break;

                    case 4:
                        FindAge();
                        break;

                    case 5:
                        SortBuss();
                        break;

                    case 6:
                        running = false;
                        Console.WriteLine("Programmet avslutas...");
                        Thread.Sleep(1000);
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
            }
        }

        // Metod för att lägga till passagerare
        public void AddPassenger()
        {
            Console.Write("Ange passagerarens ålder: ");
            try
            {
                int age = int.Parse(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("Ogiltig ålder. Måste vara ett positivt tal.");
                    return;
                }

                passengers.Add(age);
                Console.WriteLine($"Passagerare tillagd (ålder: {age}). Totalt antal passagerare: {passengers.Count}");
            }
            catch
            {
                Console.WriteLine("Felaktig inmatning. Ange ett giltigt nummer.");
            }
        }

        // Metod för att skriva ut alla passagerare
        public void PrintBuss()
        {
            if (passengers.Count == 0)
            {
                Console.WriteLine("Bussen är tom.");
                return;
            }

            Console.WriteLine("\nPassagerare på bussen:");
            for (int i = 0; i < passengers.Count; i++)
            {
                Console.WriteLine($"Säte {i + 1}: {passengers[i]} år gammal");
            }
        }

        // Metod för att beräkna genomsnittsålder
        public void CalcAverageAge()
        {
            if (passengers.Count == 0)
            {
                Console.WriteLine("Det finns inga passagerare att beräkna medelålder för.");
                return;
            }

            double total = 0;
            foreach (int age in passengers)
            {
                total += age;
            }

            double average = total / passengers.Count;
            Console.WriteLine($"Den genomsnittliga åldern på passagerarna är: {average:F1} år");
        }

        // Metod för att hitta passagerare med viss ålder eller intervall
        public void FindAge()
        {
            Console.Write("Ange minimiålder: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Ange maxålder: ");
            int max = int.Parse(Console.ReadLine());

            Console.WriteLine($"Passagerare mellan {min} och {max} år:");

            bool found = false;
            for (int i = 0; i < passengers.Count; i++)
            {
                if (passengers[i] >= min && passengers[i] <= max)
                {
                    Console.WriteLine($"Säte {i + 1}: {passengers[i]} år gammal");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Inga passagerare hittades i det åldersintervallet.");
            }
        }

        // Metod för att sortera listan (bubble sort)
        public void SortBuss()
        {
            if (passengers.Count < 2)
            {
                Console.WriteLine("Det finns inte tillräckligt många passagerare för att sortera.");
                return;
            }

            for (int i = 0; i < passengers.Count - 1; i++)
            {
                for (int j = 0; j < passengers.Count - i - 1; j++)
                {
                    if (passengers[j] > passengers[j + 1])
                    {
                        // Byt plats
                        int temp = passengers[j];
                        passengers[j] = passengers[j + 1];
                        passengers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Passagerarna har sorterats efter ålder i stigande ordning.");
        }
    }

}

