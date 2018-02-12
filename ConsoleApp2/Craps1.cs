using System;

namespace ConsoleApp2
{
    class Program
    {
        static Random rand = new Random();

        public static void Main(string[] args)
        {
            int wins = 0;
            int turns = 10;

            for (var i = 0; i < turns; i++)
            {
                int dice1 = rand.Next(1, 7);
                int dice2 = rand.Next(1, 7);
                int diceTotal = dice1 + dice2;


                Console.WriteLine("You've rolled " + dice1 + " and " + dice2 + ". You have " + diceTotal + " in total.");

                if (diceTotal == 7 | diceTotal == 11)
                {
                    Console.WriteLine("You Win!");
                    wins++;
                }
                else if (diceTotal == 2 | diceTotal == 3 | diceTotal == 12)
                {
                    Console.WriteLine("You Loose...");
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                
                Console.ReadKey();
                
            }
            Console.WriteLine("You won " + wins + " out of " + turns + " turns.");
        }

    }

}

