using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    public class Pole
    {
        public Pole(int numberOfDiscs)
        {
            discs = numberOfDiscs;
        }

        public int Discs
        {
            get
            {
                return discs;
            }

            set
            {
                discs = value;

            }
        }

        private int discs = 0;
    }
}
