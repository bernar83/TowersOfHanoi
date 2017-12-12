using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = AskForDiscs();

            Stack<int> from = new Stack<int>();
            Stack<int> to = new Stack<int>();
            Stack<int> aux = new Stack<int>();
            AddDiscs(number, from);

            Move(number, from, aux, to);

            Console.ReadKey();
        }

        // from, aux, to

        private static void Move(int number, params Stack<int>[] args)
        {
            if (number > 0)
            {
                ShowStacks(args);

                Move(number - 1, args[0], args[2], args[1]);

                int movedDisc = args[0].Pop();
                args[2].Push(movedDisc);

                ShowStacks(args[0], args[1], args[2]);

                Move(number - 1, args[1], args[0], args[2]);
            }
        }

        private static void ShowStacks(params Stack<int>[] args)
        {
            for (var i = 0; i < args.Length; i++)
            {
                if (args[i].Count > 0)
                {
                    foreach (var disc in args[i])
                    {
                        Console.Write(disc);
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        private static void AddDiscs(int number, Stack<int> pole)
        {
            for (var i = 1; i <= number; i++)
            {
                pole.Push(i);
            }
        }

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
