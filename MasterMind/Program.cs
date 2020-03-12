using System;

namespace MasterMind
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MasterMind");
            MasterMind masterMind = new MasterMind();
            String input = Console.ReadLine();
            string result = masterMind.RunCode(input);
            Console.WriteLine(result);
        }
    }
}
