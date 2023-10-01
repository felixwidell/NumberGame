namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj svårighetsgrad, skriv högsta siffran som kan genereras");
            Console.Write("Högsta:");
            string highest = Console.ReadLine();
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            int number = random.Next(1, int.Parse(highest));
            
            for(int i = 0; i < 5; i++)
            {
                string guess = Console.ReadLine();
                Console.WriteLine("\n");
                if(CheckGuess(guess, number))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Grattis " + guess + " var rätt nummer");
                    Console.ResetColor();
                    break;
                }
                else if(i == 4)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Game Over rätt nummer var " + number);
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.WriteLine((4 - i) + " gissningar kvar\n");
                }
            }
            Console.WriteLine("Starta om spelet? skriv 'ja' för att spela igen");
            string omstart = Console.ReadLine();

            if(omstart.ToLower() == "ja")
            {
                Console.Clear();
                Main(new string[]{});
            }
        }

        public static bool CheckGuess(string guess, int number)
        {
            if(int.Parse(guess) > number)
            {
                Console.WriteLine("Tyvärr du gissade för högt");
                return false;
            }
            else if(int.Parse(guess) < number)
            {
                Console.WriteLine("Tyvärr du gissade för lågt");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}