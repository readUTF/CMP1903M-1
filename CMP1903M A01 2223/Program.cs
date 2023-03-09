using System;
using System.ComponentModel;

namespace CMP1903M_A01_2223
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the card shuffling program!");

            Console.WriteLine("Please select from one of the following modes:");
            Console.WriteLine("1. Run tests");
            Console.WriteLine("2. Shuffle pack");

            int mode = 0;

            while (mode != 1 && mode != 2)
            {
                string input = Console.ReadLine();
                if (input == null) continue;
                mode = Int32.Parse(input);
            }

            
            
            switch (mode)
            {
                case 1:
                    new Testing();
                    break;
                case 2:
                    new ShuffleApp();
                    break;
            }
        }
    }
}