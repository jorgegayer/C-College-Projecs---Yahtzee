using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public  class Player
    {
        /*Player profile*/
        public string Name { get; set; }
        public Hand Hand { get; set; }
        public int TurnCount { get; set; } = 0;
        public int TotalPoints { get; set; }

        /*Upper section combinations*/
        public Number Ones { get; set; }
        public Number Twos { get; set; }
        public Number Threes { get; set; }
        public Number Fours { get; set; }
        public Number Fives { get; set; }
        public Number Sixes { get; set; }

        /*Lower section combinations*/
        public ThreeOfAKind ThreeOfAKind { get; set; }
        public FourOfAKind FourOfAKind { get; set; }
        public FullHouse FullHouse { get; set; }
        public Chance Chance { get; set; }
        public Yahtzee Yahtzee { get; set; }
        public SmallStraight SmallStraight { get; set; }
        public LargeStraight LargeStraight { get; set; }

        public Player ()
        {
            Hand = new Hand();
            Ones = new Number("One", 1);
            Twos = new Number("Two", 2);
            Threes = new Number("Three", 3);
            Fours = new Number("Four", 4);
            Fives = new Number("Five", 5);
            Sixes = new Number("Six", 6);

            ThreeOfAKind = new ThreeOfAKind();
            FourOfAKind = new FourOfAKind();
            FullHouse = new FullHouse();
            Chance = new Chance();
            Yahtzee = new Yahtzee();
            LargeStraight = new LargeStraight();
            SmallStraight = new SmallStraight();
        }

        public bool isComplete()
        {

            if (Ones.Enabled)
            {
                return false;
            }
            if (Twos.Enabled)
            {
                return false;
            }
            if (Threes.Enabled)
            {
                return false;
            }
            if (Fours.Enabled)
            {
                return false;
            }
            if (Fives.Enabled)
            {
                return false;
            }
            if (Sixes.Enabled)
            {
                return false;
            }
            if (ThreeOfAKind.Enabled)
            {
                return false;
            }
            if (FourOfAKind.Enabled)
            {
                return false;
            }
            if (FullHouse.Enabled)
            {
                return false;
            }
            if (SmallStraight.Enabled)
            {
                return false;
            }
            if (LargeStraight.Enabled)
            {
                return false;
            }
            if (Chance.Enabled)
            {
                return false;
            }
            if (Yahtzee.Enabled)
            {
                return false;
            }

            return true;
        }

        public void RollDice ()
        {
            TurnCount++;
            Hand.RollDice();
            //Hand = new Hand();
            //Ones = new Number("One", 1);
            //Twos = new Number("Two", 2);
            //Threes = new Number("Three", 3);
            //Fours = new Number("Four", 4);
            //Fives = new Number("Five", 5);
            //Sixes = new Number("Six", 6);

            //ThreeOfAKind = new ThreeOfAKind();
            //FourOfAKind = new FourOfAKind();
            //FullHouse = new FullHouse();
            //Chance = new Chance();
            //Yahtzee = new Yahtzee();
            //LargeStraight = new LargeStraight();
            //SmallStraight = new SmallStraight();
        }

        /*Player methods*/
        public int dieQty()
        {
            return 1;
        }

        public int CalculateHand()
        {
            return 1;
        }
    }
}