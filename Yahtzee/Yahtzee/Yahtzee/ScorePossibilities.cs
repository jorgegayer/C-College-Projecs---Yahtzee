using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class ThreeOfAKind : Cell
    {
        public ThreeOfAKind ()
        {
            _valueToCheck = 3;
        }
    }

    public class FourOfAKind : Cell
    {
        public FourOfAKind()
        {
            _valueToCheck = 4;
        }
    }

    public class Chance : Cell
    {
        public Chance()
        {
            _valueToCheck = 1;
        }
    }

    public class FullHouse : Cell
    {
        public FullHouse ()
        {
            Value = 25;
        }

        public override void SetPoints(Hand hand)
        {
            int[] dice = { 0, 0, 0, 0, 0, 0 };
            int sum = 0;
            bool found3 = false;
            bool found2 = false;

            foreach (var item in hand.Dice)
            {
                dice[item.SortedValue - 1]++;
                sum += item.SortedValue;
            }

            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 3) found3 = true;
                if (dice[i] == 2) found2 = true;
            }

            if (found2 && found3 )
            {
                Points = Value;
            }
        }
    }

    public class Yahtzee : Cell
    {
        public Yahtzee()
        {
            _valueToCheck = 5;
            Value = 50;
        }
    }

    public class Straight : Cell
    {
        protected int Quantity { get; set; }
        public override void SetPoints(Hand hand)
        {
            if (Enabled)
            {
                List<int> values = new List<int>();

                // Remove the duplicates
                for (int i = 0; i <= hand.Dice.Count - 1; i++)
                {
                    if (i == values.Count - 1) break;
                    if (!values.Contains(hand.Dice[i].SortedValue))
                    {
                        values.Add(hand.Dice[i].SortedValue);
                    }
                }

                values.Sort();

                //Remove what is not in sequence
                for (int i = 0; i < values.Count - 1; i++)
                {
                    if (i == values.Count - 1)
                    {
                        if (values[i] - 1 != values[i - 1])
                        {
                            values.RemoveAt(i);
                        }
                    }
                    else
                    {
                        if (values[i] != values[i + 1] - 1)
                        {
                            if (i == 0)
                                values.RemoveAt(i);
                            else
                                values.Clear();
                        }
                    }
                }
                defineValue(values);
            }
        }

        public virtual void  defineValue(List<int> values)
        {

        }
    }

    public class LargeStraight : Straight
    {
        public LargeStraight() 
        {
            Quantity = 5;
            Value = 40;
        }

         public override void defineValue(List<int> values )
         {
            if (values.Count == 5 && Quantity == 5)
            {
                Points = 40;
            }
            else
            {
                Points = 0;
            }
         }
    }

    public class SmallStraight : Straight
    {
        public SmallStraight() 
        {
            Quantity = 4;
            Value = 30;
        }

        public override void defineValue(List<int> values)
        {
            if (values.Count == 4 || values.Count == 5)
            {
                Points = 30;
            }
            else
            {
                Points = 0;
            }
        }
    }
}