using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class Number : Cell
    {
        //public string Name { get; set; }
        //public int Value { get; set; }
        //public bool Fixed { get; set; }
        //public int Points { get; set; } = 0;
        //public virtual void SetPoints()
        //{
        //    Points++;
        //}

        public Number(string name, int value) 
        {
            Name = name;
            Value = value;
        }
        
        public override void  SetPoints(Hand hand)
        {
            if (Enabled)
            {
                Points = 0;
                foreach (var item in hand.Dice)
                {
                    if (item.SortedValue == Value && Enabled == true)
                    {
                        Points += Value;
                    }
                }
            }
        }
    }
}