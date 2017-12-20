using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Program
    {
        // ================
        // Data definition:
        // Disc is Integer
        // interp. number of discs on a pole

        //private static void DiscFunction(int d)
        //{
        //    ... d
        //}

        // ================
        // Functions:
        // Disc -> Disc

        static void Main(string[] args)
        {
            int number = AskForDiscs();     // Integer -> Integer

            List<int> from = new List<int>();
            List<int> to = new List<int>();
            List<int> aux = new List<int>();
            AddDiscs(number, from);         // Integer, List -> List
            ShowStacks(from, aux, to);      // List, List, List -> List, List, List
            //Move(number, from, aux, to);

            Console.ReadKey();
        }

        // from, aux, to

        private static void Move(int number, params Stack<int>[] args)
        {
            if (number > 0)
            {
                // keep rest
                //Move(number - 1, args[0], args[2], args[1]);

                //int movedDisc = args[0].Pop();
                //args[2].Push(movedDisc);

                //ShowStacks(args[0], args[1], args[2]);

                //Move(number - 1, args[1], args[0], args[2]);
            }
        }

        // List, List, List -> List, List, List
        // Print the amount of discs to console
        private static void ShowStacks(List<int> from, List<int> aux, List<int> to)
        {
            List<int>[] poles = new List<int>[] { from, aux, to };
            for (int i = 0; i < 3; i++)
            {
                List<int> selectedPole = poles[i];
                if (selectedPole.Count == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    foreach (int disc in selectedPole)
                    {
                        Console.Write(disc);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("============================================");
        }

        // Integer, List -> List
        // Add number of discs to pole
        private static void AddDiscs(int number, List<int> pole)
        {
            for (var i = number; i > 0; i--)
            {
                pole.Add(i);
            }
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
