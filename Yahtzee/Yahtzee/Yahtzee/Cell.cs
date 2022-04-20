using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    enum GamesCombination { Ones = 1, Twos = 2, Threes = 3, Fours = 4, Fives = 5, Sixes = 6, ThreeOfAKind = 7, FourOfAKind = 8, FullHouse = 9, SmallStraight = 10, LargeStraight = 11, Chance = 12, Yahtzee = 13 }
    public abstract class Cell
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public bool Enabled { get; set; } = true;
        public int Points { get; set; } = 0;
        protected int _valueToCheck = 0;

        public virtual void SetPoints(Hand hand)
        {
            if (Enabled)
            {
                CalculatePointsValues(hand);
            }
        }

        public void ResetPoint()
        {
            if (Enabled)
            {
                Points = 0;
            }
        }

        protected virtual void CalculatePointsValues(Hand hand)
        {
            if (Enabled)
            {
                int[] dice = { 0, 0, 0, 0, 0, 0 };
                int sum = 0;

                foreach (var item in hand.Dice)
                {
                    dice[item.SortedValue - 1]++;
                    sum += item.SortedValue;
                }
                for (int i = 0; i < dice.Length; i++)
                {
                    if (dice[i] >= _valueToCheck)
                    {
                        if (Value == 0)
                            Points = sum;
                        else
                            Points = Value;
                    }
                }
            }
        }
    }
}