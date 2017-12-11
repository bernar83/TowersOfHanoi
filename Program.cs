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
            bool isNumber = false;
            int number = 0;
            while (!isNumber)
            {
                Console.Write("Enter number of discs: ");
                var input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);
            }


            Console.ReadKey();
        }
        
    }
}
