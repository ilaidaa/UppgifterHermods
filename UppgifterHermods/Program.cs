namespace UppgifterHermods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UPPGIFT 1: PENSIONEN
            Console.WriteLine("Välkomna till denna pensionssimulator.\n");


            // Inmatning och felhantering
            Console.Write("Vad heter du i förnman? : ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Ogiltig inmatning. Försök igen. ");
                Thread.Sleep(1000);
                return;
            }

            Console.Write("Hur gammal är du? : ");
           
            if(!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Ogiltig inmatning. Försök igen. ");
                Thread.Sleep(1000);
                return;
            }


            // Pensions uträkning
            int pensionAge = 65;
            int yearsLeft = pensionAge - age;


            // Output
            if(yearsLeft > 0)
            {
                Console.WriteLine($"\nHej {name}. Du går i pension om {yearsLeft} år. ");
            }
            else
            {
                Console.WriteLine($"\nHej {name}. Du har redan passerat pensionsåldern!");
            }


            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey(true);



















            // UPPGIFT 2: GISSA TALET

            int rightNumber = new Random().Next(1, 101);

            // Input
            Console.WriteLine("GISSA TALET");
            Console.WriteLine("Du ska nu gissa ett tal mellan 1 - 100, så varsågod . .\n");
            Console.Write("Skriv in ett tal: ");

            // Felhantering kolla att det är ett heltal
            if (!int.TryParse(Console.ReadLine(), out int guess))
            {
                Console.WriteLine("Ogiltig inmatning");
                Thread.Sleep(1000);
                return; 
            }

            // Om talet är utanför intervallet
            if (guess > 100 || guess < 1)
            {
                Console.WriteLine("Du måste skriva in ett tal mellan 1 till 100!");
                Thread.Sleep(1000);
                return; 
            }

            // Om talet är rätt
            if(guess == rightNumber)
            {
                Console.WriteLine("Du har gissat rätt!");
                Thread.Sleep(1000);
                return;
            }


            // Om talet är för stort
            if (rightNumber < guess)
            {
                Console.WriteLine("Ditt tal är för stort. Skriv ett mindre.");
            }
            // Om talet är för litet
            else if (rightNumber > guess)
            {
                Console.WriteLine("Ditt tal är för lågt. Skriv ett större. ");
            }


            // Om man är nära (t.ex. inom 3 steg)
            if (Math.Abs(rightNumber - guess) <= 3)
            {
                Console.WriteLine("Du är nära och det bränns");
            }

            Console.WriteLine("\nProgrammet är slut");

        }
    }
}
