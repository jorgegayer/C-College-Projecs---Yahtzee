using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public class Hand
    {
        public List<Die> Dice = new List<Die>();
        //public int QtyDie { get; set; }

        public Hand ()
        {
            for (int i = 1; i <= 5; i++)
            {
                Die localDie = new Die();
                localDie.Id = i;

                Dice.Add(localDie);
                localDie = null;
            }
        }

        public void Unhold()
        {
            foreach (var item in Dice)
            {
                item.Unhold();
            }
        }

        public void RollDice()   
        {
            foreach (var item in Dice)
            {
                item.Roll();
            }
        }

        public BorderStyle HoldDie(int DieID)
        {
            foreach (var item in Dice)
            {
                if(item.Id == DieID)
                {
                    item.Held = !item.Held;
                    if (item.Held)
                    {
                        return BorderStyle.Fixed3D;
                    }else
                    {
                        return BorderStyle.None;
                    }
                }
            }
            return BorderStyle.None;
        }

        //public void DisplayNumbers(int[] id)
        //{
        //    for (int i = 1; i < id.Length; i++)
        //    {
        //        Console.WriteLine(id[i]);
        //    }
        //}
    }
}