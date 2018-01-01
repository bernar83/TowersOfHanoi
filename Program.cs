using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Program
    {
        // ===================
        // Data definition:
        // Disc is Integer
        // interp. number of discs on a pole

        //private static void DiscFunction(int d)
        //{
        //    ... d
        //}

        // ===================
        // Functions:
        // Disc -> Disc

        static void Main(string[] args)
        {
            int number = AskForDiscs();     // Integer -> Integer

            ShowStacks(from, aux, to);      // List, List, List -> List, List, List
            Move(number, from, aux, to);    // Integer, List, List, List 

            Console.ReadKey();
        }

        // Integer -> Integer
        // Asks for number of discs to start with
        private static int AskForDiscs()
        {
            bool isNumber = false;
            int number = 0;
            while (!isNumber)
            {
                Console.Write("Enter number of discs: ");
                var input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);
            }
            return number;
        }
    }
}
