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


















            // UPPGIFT 3: GISSA TALET - förbättrad version med do-while loop

            // Skapa slumpmässigt tal mellan 1 och 100
            int rightNr = new Random().Next(1, 101);
            int playerGuess = 0; // spelarens gissning

            // Input
            Console.WriteLine("GISSA TALET");
            Console.WriteLine("Du ska nu gissa ett tal mellan 1 - 100, så varsågod . .\n");

            do
            {
                Console.Write("Skriv in ett tal: ");

                // Kontrollera att användaren skriver ett heltal
                if (!int.TryParse(Console.ReadLine(), out playerGuess))
                {
                    Console.WriteLine("Ogiltig inmatning! Du måste skriva ett heltal.\n");
                    continue; // hoppar över resten av loopen och börjar om
                }

                // Kontrollera att talet är inom intervallet
                if (playerGuess < 1 || playerGuess > 100)
                {
                    Console.WriteLine("Du måste skriva in ett tal mellan 1 och 100!\n");
                    continue;
                }

                // Om talet är rätt
                if (playerGuess == rightNr)
                {
                    Console.WriteLine("Du har gissat rätt! Bra jobbat!");
                    break; // avsluta loopen
                }

                // Ge ledtrådar
                if (playerGuess > rightNr)
                {
                    Console.WriteLine("Ditt tal är för stort. Försök med ett mindre.");
                }
                else
                {
                    Console.WriteLine("Ditt tal är för lågt. Försök med ett större.");
                }

                // Om man är nära (inom 3 steg)
                if (Math.Abs(rightNr - playerGuess) <= 3)
                {
                    Console.WriteLine("Du är riktigt nära, det bränns!");
                }

                Console.WriteLine();

            }
            while (true);

            Console.WriteLine("\nSpelet är slut. Tack för att du spelade!");
            Thread.Sleep(1000);





















            // UPPGIFT 4: Lottobollar och Bingo
            // Denna uppgift simulerar en bingorad med 10 tal och kontrollerar
            // om det slumpade talet finns i listan. Om det finns, skrivs "Bingo!".
            // Skapa slumpgenerator
            Random randomGenerator = new Random();

            // Skapa lista 
            List<int> bingoList = new List<int>();

            Console.WriteLine("BINGO");
            Console.WriteLine("Skriv in 10 tal mellan 1 och 20.\n");

            // Användaren fyller i listan med 10 tal
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Ange tal {i}: ");

                // Läser in tal å omvandlar 
                int number = int.Parse(Console.ReadLine());

                // Lägger till talet i listan
                bingoList.Add(number);
            }

            Console.WriteLine("\nDina bingotal är:");
            Console.WriteLine(string.Join(", ", bingoList));

            // Slumpar fram ett tal 
            int randomNumber = randomGenerator.Next(1, 21);
            Console.WriteLine($"\nDen slumpade lottobollen är: {randomNumber}");

            // Kontrollera om talet finns
            bool bingo = false;

            foreach (int number in bingoList)
            {
                if (number == randomNumber)
                {
                    bingo = true;
                    break;
                }
            }

            // Skriv ut resultat
            if (bingo)
            {
                Console.WriteLine("BINGO! Du hade numret på din rad!");
            }
            else
            {
                Console.WriteLine("Tyvärr, ingen bingo den här gången.");
            }

            Console.WriteLine("\nTack för att du spelade!");
        }
    }
}
