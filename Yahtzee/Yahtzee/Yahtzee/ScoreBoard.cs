using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class ScoreBoard
    {
        public Player Player1 { set; get; }
        public Player Player2 { set; get; }
        private bool _turn;
        public Player Winner { get; set; }


        public ScoreBoard ()
        {
            Player1 = new Player();
            Player2 = new Player();
            Winner = new Player();
            Winner.Name = "NO";
            _turn = true;
        }


        
        public void RollDice()
        {
            CurrentPlayer().RollDice();
            CurrentPlayer().Ones.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().Twos.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().Threes.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().Fours.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().Fives.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().Sixes.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().ThreeOfAKind.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().LargeStraight.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().FourOfAKind.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().FullHouse.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().Chance.SetPoints(CurrentPlayer().Hand);
            CurrentPlayer().Yahtzee.SetPoints(CurrentPlayer().Hand);
        }

        public Player CurrentPlayer()
        {
            if (_turn)
            {
                return Player1;
            }
            else
            {
                return Player2;
            }
        }

        public void NextPlayer()
        {


            CurrentPlayer().Ones.ResetPoint();
            CurrentPlayer().Twos.ResetPoint();
            CurrentPlayer().Threes.ResetPoint();
            CurrentPlayer().Fours.ResetPoint();
            CurrentPlayer().Fives.ResetPoint();
            CurrentPlayer().Sixes.ResetPoint();
            CurrentPlayer().ThreeOfAKind.ResetPoint();
            CurrentPlayer().LargeStraight.ResetPoint();
            CurrentPlayer().FourOfAKind.ResetPoint();
            CurrentPlayer().FullHouse.ResetPoint();
            CurrentPlayer().Chance.ResetPoint();
            CurrentPlayer().Yahtzee.ResetPoint();
            _turn = !_turn;
            CheckWinner();
        }

        public void Unhold()
        {
            CurrentPlayer().Hand.Unhold();
        }
        public void HoldGame(GamesCombination value)
        {
            if (value == GamesCombination.Ones)
            {
                CurrentPlayer().Ones.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().Ones.Points;
            }

            if (value == GamesCombination.Twos)
            {
                CurrentPlayer().Twos.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().Twos.Points;
            }
            
            if (value == GamesCombination.Threes)
            {
                CurrentPlayer().Threes.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().Threes.Points;
            }
            
            if (value == GamesCombination.Fours)
            {
                CurrentPlayer().Fours.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().Fours.Points;
            }
            
            if (value == GamesCombination.Fives)
            {
                CurrentPlayer().Fives.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().Fives.Points;
            }
            
            if (value == GamesCombination.Sixes)
            {
                CurrentPlayer().Sixes.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().Sixes.Points;
            }
            
            if (value == GamesCombination.ThreeOfAKind)
            {
                CurrentPlayer().ThreeOfAKind.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().ThreeOfAKind.Points;
            }
            
            if (value == GamesCombination.FourOfAKind)
            {
                CurrentPlayer().FourOfAKind.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().FourOfAKind.Points;
            }
            
            if (value == GamesCombination.FullHouse)
            {
                CurrentPlayer().FullHouse.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().FullHouse.Points;
            }
            
            if (value == GamesCombination.Chance)
            {
                CurrentPlayer().Chance.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().Chance.Points;
            }
            
            if (value == GamesCombination.Yahtzee)
            {
                CurrentPlayer().Yahtzee.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().Yahtzee.Points;
            }
            
            if (value == GamesCombination.SmallStraight)
            {
                CurrentPlayer().SmallStraight.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().SmallStraight.Points;
            }

            if (value == GamesCombination.LargeStraight)
            {
                CurrentPlayer().LargeStraight.Enabled = false;
                CurrentPlayer().TotalPoints += CurrentPlayer().LargeStraight.Points;
            }


        }
        private void CheckWinner()
        {
            Player player = new Player();
            player.Name = "NO";
            if (Player1.isComplete() && Player2.isComplete())
            {
                if (Player1.TotalPoints > Player2.TotalPoints)
                {
                    player = Player1;
                }else if (Player2.TotalPoints > Player1.TotalPoints)
                {
                    player = Player2;
                }
            }
            Winner =  player;
        }
    }
}