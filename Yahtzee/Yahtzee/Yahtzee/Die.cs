using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Die
    {
        static Random r = new Random();
        public int Id { get; set; }
        public int SortedValue { get; set; }
        public bool Held = false;

        public int Roll()
        { 
            int i = SortedValue;

            if (!Held)
            {
                i = r.Next(1, 7);
                SortedValue = i;
            }
            return i;
        }

        public void SwitchHold()
        {
            Held = !Held;
        }

        public void Unhold()
        {
            Held = false;
        }
    }
}