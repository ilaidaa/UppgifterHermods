namespace UppgifterHermods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uppgift 1: Pensionen
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
        }
    }
}
