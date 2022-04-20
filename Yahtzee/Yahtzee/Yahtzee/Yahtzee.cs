using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class frmMain : Form
    {
        ScoreBoard scoreBoard = new ScoreBoard();
        private int CountMoves { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Chance);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.LargeStraight);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void label19_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.SmallStraight);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void label21_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.FullHouse);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            //tmrSort.Start();
            //tmrTimer.Start();

            CountMoves++;
            scoreBoard.RollDice();
            if (CountMoves==1)
            {
                EnableDice();
            }

            if (scoreBoard.CurrentPlayer().Name == "Player 1")
            {
                grp1.Enabled = true;
                grp1Games.Enabled = true;
                lblP1ThreeOfaKind.Text = scoreBoard.CurrentPlayer().ThreeOfAKind.Points.ToString();
                lblP1SmallStraight.Text = scoreBoard.CurrentPlayer().SmallStraight.Points.ToString();
                lblP1LargeStraight.Text = scoreBoard.CurrentPlayer().LargeStraight.Points.ToString();
                lblP1FourOfaKind.Text = scoreBoard.CurrentPlayer().FourOfAKind.Points.ToString();
                lblP1FullHouse.Text = scoreBoard.CurrentPlayer().FullHouse.Points.ToString();
                lblP1Chance.Text = scoreBoard.CurrentPlayer().Chance.Points.ToString();
                lblP1Yahtzee.Text = scoreBoard.CurrentPlayer().Yahtzee.Points.ToString();

                lblP1One.Text = scoreBoard.CurrentPlayer().Ones.Points.ToString();
                lblP1Two.Text = scoreBoard.CurrentPlayer().Twos.Points.ToString();
                lblP1Three.Text = scoreBoard.CurrentPlayer().Threes.Points.ToString();
                lblP1Four.Text = scoreBoard.CurrentPlayer().Fours.Points.ToString();
                lblP1Five.Text = scoreBoard.CurrentPlayer().Fives.Points.ToString();
                lblP1Six.Text = scoreBoard.CurrentPlayer().Sixes.Points.ToString();

                lblDie1.Text = scoreBoard.CurrentPlayer().Hand.Dice[0].SortedValue.ToString();
                lblDie2.Text = scoreBoard.CurrentPlayer().Hand.Dice[1].SortedValue.ToString();
                lblDie3.Text = scoreBoard.CurrentPlayer().Hand.Dice[2].SortedValue.ToString();
                lblDie4.Text = scoreBoard.CurrentPlayer().Hand.Dice[3].SortedValue.ToString();
                lblDie5.Text = scoreBoard.CurrentPlayer().Hand.Dice[4].SortedValue.ToString();

            }
            else
            {
                grp2.Enabled = true;
                grp2Games.Enabled = true;
                lblP2ThreeOfaKind.Text = scoreBoard.CurrentPlayer().ThreeOfAKind.Points.ToString();
                lblP2SmallStraight.Text = scoreBoard.CurrentPlayer().SmallStraight.Points.ToString();
                lblP2LargeStraight.Text = scoreBoard.CurrentPlayer().LargeStraight.Points.ToString();
                lblP2FourOfaKind.Text = scoreBoard.CurrentPlayer().FourOfAKind.Points.ToString();
                lblP2FullHouse.Text = scoreBoard.CurrentPlayer().FullHouse.Points.ToString();
                lblP2Chance.Text = scoreBoard.CurrentPlayer().Chance.Points.ToString();
                lblP2Yahtzee.Text = scoreBoard.CurrentPlayer().Yahtzee.Points.ToString();

                lblP2One.Text = scoreBoard.CurrentPlayer().Ones.Points.ToString();
                lblP2Two.Text = scoreBoard.CurrentPlayer().Twos.Points.ToString();
                lblP2Three.Text = scoreBoard.CurrentPlayer().Threes.Points.ToString();
                lblP2Four.Text = scoreBoard.CurrentPlayer().Fours.Points.ToString();
                lblP2Five.Text = scoreBoard.CurrentPlayer().Fives.Points.ToString();
                lblP2Six.Text = scoreBoard.CurrentPlayer().Sixes.Points.ToString();

                lblDie1.Text = scoreBoard.CurrentPlayer().Hand.Dice[0].SortedValue.ToString();
                lblDie2.Text = scoreBoard.CurrentPlayer().Hand.Dice[1].SortedValue.ToString();
                lblDie3.Text = scoreBoard.CurrentPlayer().Hand.Dice[2].SortedValue.ToString();
                lblDie4.Text = scoreBoard.CurrentPlayer().Hand.Dice[3].SortedValue.ToString();
                lblDie5.Text = scoreBoard.CurrentPlayer().Hand.Dice[4].SortedValue.ToString();
            }

            if (CountMoves==3)
            {
                btnRollDice.Enabled = false;
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tmrSort.Stop();
        }

        private void tmrSort_Tick(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            scoreBoard.Player1.Name = "Player 1";
            scoreBoard.Player2.Name = "Player 2";
        }

        private void spmethjing()
        {

        }

        private void lblP1One_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Ones);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP1Two_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Twos);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP1Three_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Threes);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP1Four_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Fours);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP1Five_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Fives);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP1Six_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Sixes);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP1ThreeOfaKind_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.ThreeOfAKind);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP1FourOfaKind_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.FourOfAKind);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP1Yahtzee_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Yahtzee);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2One_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Ones);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2Two_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Twos);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2Three_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Threes);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2Four_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Fours); 
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2Five_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Fives);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2Six_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Sixes);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2ThreeOfaKind_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.ThreeOfAKind);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2FourOfaKind_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.FourOfAKind);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2FullHouse_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.FullHouse);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2SmallStraight_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.SmallStraight);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2LargeStraight_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.LargeStraight);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2Chance_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Chance);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void lblP2Yahtzee_Click(object sender, EventArgs e)
        {
            scoreBoard.HoldGame(GamesCombination.Yahtzee);
            Label label = (Label)sender;
            UpdateTotal(label);
        }

        private void UpdateTotal(Label sender)
        {
            if (scoreBoard.CurrentPlayer().Name == "Player 1")
            {
                lblP1Total.Text = scoreBoard.CurrentPlayer().TotalPoints.ToString();
            }
            else
            {
                lblP2Total.Text = scoreBoard.CurrentPlayer().TotalPoints.ToString();
            }

            sender.ForeColor = Color.Green;
            sender.Font = new Font(sender.Font, FontStyle.Bold);
            sender.Enabled = false;

            ChangePlayer();
        }

        private void ChangePlayer ()
        {
            CountMoves = 0;
            scoreBoard.NextPlayer();
            scoreBoard.Unhold();
            if (scoreBoard.Winner.Name == "NO")
            {
                if (scoreBoard.CurrentPlayer().Name == "Player 1")
                {
                    lblP1Turn.Visible = true;
                    lblP2Turn.Visible = false;
                    grp2.Enabled = false;
                    grp2Games.Enabled = false;
                }
                else
                {
                    lblP1Turn.Visible = false;
                    lblP2Turn.Visible = true;
                    grp1.Enabled = false;
                    grp1Games.Enabled = false;
                }

                lblDie1.BorderStyle = BorderStyle.None;
                lblDie2.BorderStyle = BorderStyle.None;
                lblDie3.BorderStyle = BorderStyle.None;
                lblDie4.BorderStyle = BorderStyle.None;
                lblDie5.BorderStyle = BorderStyle.None;
                btnRollDice.Enabled = true;

                DisableDice();
            }
            else
            {
                DefineWinner(); 
            }
        }

        private void DefineWinner()
        {
            btnRestart.Visible = true;
            lblWinner.Text = scoreBoard.Winner.Name + " Wins!";
            lblWinner.Visible = true;
            btnRollDice.Enabled = false;
            DisableDice();
            grp1.Enabled = false;
            grp2.Enabled = false;
            grp1Games.Enabled = false;
            grp2Games.Enabled = false;
        }
        private void lblDie1_Click(object sender, EventArgs e)
        {
            lblDie1.BorderStyle  = scoreBoard.CurrentPlayer().Hand.HoldDie(1);
        }

        private void lblDie2_Click(object sender, EventArgs e)
        {
            lblDie2.BorderStyle = scoreBoard.CurrentPlayer().Hand.HoldDie(2);
        }

        private void lblDie3_Click(object sender, EventArgs e)
        {
            lblDie3.BorderStyle = scoreBoard.CurrentPlayer().Hand.HoldDie(3);
        }

        private void lblDie4_Click(object sender, EventArgs e)
        {
            lblDie4.BorderStyle = scoreBoard.CurrentPlayer().Hand.HoldDie(4);
        }

        private void lblDie5_Click(object sender, EventArgs e)
        {
            lblDie5.BorderStyle = scoreBoard.CurrentPlayer().Hand.HoldDie(5);
        }

        public void EnableDice()
        {
            lblDie1.Enabled = true;
            lblDie2.Enabled = true;
            lblDie3.Enabled = true;
            lblDie4.Enabled = true;
            lblDie5.Enabled = true;
        }
        public void DisableDice()
        {
            lblDie1.Enabled = false;
            lblDie2.Enabled = false;
            lblDie3.Enabled = false;
            lblDie4.Enabled = false;
            lblDie5.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnRestart.Visible = false;
            lblWinner.Visible = false;
            btnRollDice.Enabled = true;
            EnableDice();
            grp1.Enabled = false;
            grp1Games.Enabled = false;

            scoreBoard = new ScoreBoard();
            scoreBoard.Player1.Name = "Player 1";
            scoreBoard.Player2.Name = "Player 2";

            grp2Games.Enabled = false;
            grp2.Enabled = false;
            lblP1ThreeOfaKind.Text = "0";
            lblP1ThreeOfaKind.Enabled = true;
            lblP1ThreeOfaKind.ForeColor = Color.Black;
            lblP1ThreeOfaKind.Font = new Font(lblP1ThreeOfaKind.Font, FontStyle.Regular);


            lblP1SmallStraight.Text = "0";
            lblP1SmallStraight.Enabled = true;
            lblP1SmallStraight.ForeColor = Color.Black;
            lblP1SmallStraight.Font = new Font(lblP1SmallStraight.Font, FontStyle.Regular);


            lblP1LargeStraight.Text = "0";
            lblP1LargeStraight.Enabled = true;
            lblP1LargeStraight.ForeColor = Color.Black;
            lblP1LargeStraight.Font = new Font(lblP1LargeStraight.Font, FontStyle.Regular);



            lblP1FourOfaKind.Text = "0";
            lblP1FourOfaKind.Enabled = true;
            lblP1FourOfaKind.ForeColor = Color.Black;
            lblP1FourOfaKind.Font = new Font(lblP1FourOfaKind.Font, FontStyle.Regular);


            lblP1FullHouse.Text = "0";
            lblP1FullHouse.Enabled = true;
            lblP1FullHouse.ForeColor = Color.Black;
            lblP1FullHouse.Font = new Font(lblP1FullHouse.Font, FontStyle.Regular);


            lblP1Chance.Text = "0";
            lblP1Chance.Enabled = true;
            lblP1Chance.ForeColor = Color.Black;
            lblP1Chance.Font = new Font(lblP1Chance.Font, FontStyle.Regular);


            lblP1Yahtzee.Text = "0";
            lblP1Yahtzee.Enabled = true;
            lblP1Yahtzee.ForeColor = Color.Black;
            lblP1Yahtzee.Font = new Font(lblP1Yahtzee.Font, FontStyle.Regular);


            lblP1One.Text = "0";
            lblP1One.Enabled = true;
            lblP1One.ForeColor = Color.Black;
            lblP1One.Font = new Font(lblP1One.Font, FontStyle.Regular);


            lblP1Two.Text = "0";
            lblP1Two.Enabled = true;
            lblP1Two.ForeColor = Color.Black;
            lblP1Two.Font = new Font(lblP1Two.Font, FontStyle.Regular);


            lblP1Three.Text = "0";
            lblP1Three.Enabled = true;
            lblP1Three.ForeColor = Color.Black;
            lblP1Three.Font = new Font(lblP1Three.Font, FontStyle.Regular);


            lblP1Four.Text = "0";
            lblP1Four.Enabled = true;
            lblP1Four.ForeColor = Color.Black;
            lblP1Four.Font = new Font(lblP1Four.Font, FontStyle.Regular);

            lblP1Five.Text = "0";
            lblP1Five.Enabled = true;
            lblP1Five.ForeColor = Color.Black;
            lblP1Five.Font = new Font(lblP1Five.Font, FontStyle.Regular);

            lblP1Six.Text = "0";
            lblP1Six.Enabled = true;
            lblP1Six.ForeColor = Color.Black;
            lblP1Six.Font = new Font(lblP1Six.Font, FontStyle.Regular);

            lblP2ThreeOfaKind.Text = "0";
            lblP2ThreeOfaKind.Enabled = true;
            lblP2ThreeOfaKind.ForeColor = Color.Black;
            lblP2ThreeOfaKind.Font = new Font(lblP2ThreeOfaKind.Font, FontStyle.Regular);

            lblP2SmallStraight.Text = "0";
            lblP2SmallStraight.Enabled = true;
            lblP2SmallStraight.ForeColor = Color.Black;
            lblP2SmallStraight.Font = new Font(lblP2SmallStraight.Font, FontStyle.Regular);

            lblP2LargeStraight.Text = "0";
            lblP2LargeStraight.Enabled = true;
            lblP2LargeStraight.ForeColor = Color.Black;
            lblP2LargeStraight.Font = new Font(lblP2LargeStraight.Font, FontStyle.Regular);


            lblP2FourOfaKind.Text = "0";
            lblP2FourOfaKind.Enabled = true;
            lblP2FourOfaKind.ForeColor = Color.Black;
            lblP2FourOfaKind.Font = new Font(lblP2FourOfaKind.Font, FontStyle.Regular);

            lblP2FullHouse.Text = "0";
            lblP2FullHouse.Enabled = true;
            lblP2FullHouse.ForeColor = Color.Black;
            lblP2FullHouse.Font = new Font(lblP2FullHouse.Font, FontStyle.Regular);

            lblP2Chance.Text = "0";
            lblP2Chance.Enabled = true;
            lblP2Chance.ForeColor = Color.Black;
            lblP2Chance.Font = new Font(lblP2Chance.Font, FontStyle.Regular);


            lblP2Yahtzee.Text = "0";
            lblP2Yahtzee.Enabled = true;
            lblP2Yahtzee.ForeColor = Color.Black;
            lblP2Yahtzee.Font = new Font(lblP2Yahtzee.Font, FontStyle.Regular);


            lblP2One.Text = "0";
            lblP2One.Enabled = true;
            lblP2One.ForeColor = Color.Black;
            lblP2One.Font = new Font(lblP2One.Font, FontStyle.Regular);


            lblP2Two.Text = "0";
            lblP2Two.Enabled = true;
            lblP2Two.ForeColor = Color.Black;
            lblP2Two.Font = new Font(lblP2Two.Font, FontStyle.Regular);


            lblP2Three.Text = "0";
            lblP2Three.Enabled = true;
            lblP2Three.ForeColor = Color.Black;
            lblP2Three.Font = new Font(lblP2Three.Font, FontStyle.Regular);


            lblP2Four.Text = "0";
            lblP2Four.Enabled = true;
            lblP2Four.ForeColor = Color.Black;
            lblP2Four.Font = new Font(lblP2Four.Font, FontStyle.Regular);


            lblP2Five.Text = "0";
            lblP2Five.Enabled = true;
            lblP2Five.ForeColor = Color.Black;
            lblP2Five.Font = new Font(lblP2Five.Font, FontStyle.Regular);

            lblP2Six.Text = "0";
            lblP2Six.Enabled = true;
            lblP2Six.ForeColor = Color.Black;
            lblP2Six.Font = new Font(lblP2Six.Font, FontStyle.Regular);

            lblP1Total.Text = "0";
            lblP1Total.Text = "0";

            lblDie1.Text = "0";
            lblDie2.Text = "0";
            lblDie3.Text = "0";
            lblDie4.Text = "0";
            lblDie5.Text = "0";
            lblP1Turn.Visible = true;
            lblP2Turn.Visible = false;
            grp2.Enabled = false;
            grp2Games.Enabled = false;



        }
    }
}