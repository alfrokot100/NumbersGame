//Alfred Ochieng Osewe Okoth
//Net24
using System;
namespace NumbersGame
{
    internal class Program
    {

        static void CheckGuess()
        {
            Random random = new Random();//Calling out the Random generator to randomize numbers
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
            CheckGuess();
        }


    }
}
