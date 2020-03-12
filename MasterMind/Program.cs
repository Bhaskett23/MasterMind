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
            while (tries <= 10)
            {
                String input = Console.ReadLine();
                string result = masterMind.RunCode(input);
                Console.WriteLine(result);
                if (result.Length != 4)
                {
                    tries++;
                }                
            }
            
        }
    }
}
