using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Hanoi
    {
        private Stack<int> from = new Stack<int>();
        private Stack<int> to = new Stack<int>();
        private Stack<int> aux = new Stack<int>();
        private int number;

        public Hanoi(int number)
        {
            this.number = number;
        }

        public void Solve()
        {
            ShowStacks();
            Move(number, from, to, aux);
        }

        private void Move(int number, Stack<int> from, Stack<int> to, Stack<int> other)
        {
           if (number == 1)
           {
                to.Push(from.Pop());
                ShowStacks();
                return;
           }

            Move(number - 1, from, other, to);

            to.Push(from.Pop());
            ShowStacks();

            Move(number - 1, other, to, from);
        }

        // Integer, Stack -> Stack
        // Add number of discs to from pole
        public void AddDiscs()
        {
            for (var i = 1; i <= number; i++)
            {
                from.Push(i);
            }
        }

        // Stack, Stack, Stack -> Stack, Stack, Stack
        // Print the amount of discs to console
        private void ShowStacks()
        {
            Stack<int>[] poles = new Stack<int>[] { from, aux, to };
            for (int i = 0; i < 3; i++)
            {
                Stack<int> selectedPole = poles[i];
                if (selectedPole.Count == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    foreach (int disc in selectedPole)
                    {
                        Console.Write("{0, 5}", disc);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("============================================");
        }
    }
}
