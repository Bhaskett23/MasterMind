using System;

namespace MasterMind
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MasterMind");
            MasterMind masterMind = new MasterMind();
            int tries = 1;
            bool keepPlaying = true;
            while(keepPlaying)
            {
                while (tries <= 10)
                {
                    string input = Console.ReadLine();
                    string result = masterMind.RunCode(input);
                    Console.WriteLine(result);
                    if(result == "++++")
                    {
                        Console.WriteLine("Congrats you guessed the code correctly");
                        break;
                    }
                    else if (result.Length <= 4)
                    {
                        tries++;
                        Console.WriteLine("You have {0} tries remaining", 10-tries);
                    }
                }
                Console.WriteLine("Do you want to play again y/n?");
                string playAgain = Console.ReadLine();
                if(playAgain == "y")
                {
                    masterMind = new MasterMind();
                    tries = 1;
                }
                else
                {
                    keepPlaying = false;
                }
            }
                  
        }
    }
}
