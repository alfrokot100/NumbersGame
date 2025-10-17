//Alfred Ochieng Osewe Okoth
//Net24
using System;
namespace NumbersGame
{
    internal class Program
    {

        static void CheckGuess()
        {
            Random random = new Random();//Calling out the Random generator to randomize the numbers
            int Number = random.Next(1, 21);
                          
            for (int i = 0; i < 5; i++)//For-loop and the input user get max 5 tries
            {
                String input = Console.ReadLine();
                bool Succes = int.TryParse(input, out int result);

                if (!Succes) { Console.WriteLine("Felaktig input!"); i--; } //Try doesn't cout if user enter wrong input
                else
                {
                    if (result > Number) { Console.WriteLine("För stort tal!"); } //Ifs and elses to navigate user input
                    else if (result < Number) { Console.WriteLine("För Litet tal!"); }
                    else { Console.WriteLine("Rätt!!!!"); return; }
                }
            }
            Console.WriteLine("Du lyckades inte ): Talet var {0}!", Number);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa en siffra mellan 1 - 20");
            GuessGame();
        }


        static void GuessGame() 
        {
            Random random = new Random();
            int number = random.Next(1, 21);

            for(int i=0; i< 5; i++)
            {
                string input = Console.ReadLine();
                bool guess = int.TryParse(input, out int result);

                if (!guess) { Console.WriteLine("Felaktig input! Gör om och gör rätt"); i--; }

                if (result > number) { Console.WriteLine("För stort nummer"); }
                else if (result < number) { Console.WriteLine("För litet nummer"); }
                else { Console.WriteLine("Du gissade rätt!"); return; }

            }
            Console.WriteLine($"Du gissa inte rätt nummer tyvärr. Siffran var {number}");

        }

    }
}
