using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Program
    {
        // ==Data definition==
        // Disc is Natural
        // interp. number of discs on pole
        // (define 3-DISCS 3)
        
        //private static void DiscFunction(int d)
        //{
        //    ... d
        //}

        // ==Functions==
        // Disc -> Disc
        
        static void Main(string[] args)
        {
            int number = AskForDiscs();

            List<int> from = new List<int>();
            List<int> to = new List<int>();
            List<int> aux = new List<int>();
            AddDiscs(number, from);
            // add showstacks method here
            Move(number, from, aux, to);

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
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("==========");
        }

        private static void AddDiscs(int number, List<int> pole)
        {
            for (var i = number; number > 0 ; i--)
            {
                pole.Add(i);
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
