using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_2
{
    public partial class Form1 : Form
    {
        private Dices[] theDice = new Dices[5] { null, null, null, null, null };
        

        private int call, score;
        private int scoreCount = 0;

        private ScoreCalculation theScore = new ScoreCalculation();

        public int CallCount
        {
            get
            {
                return call;
            }
        }

        public Form1()
        {
            InitializeComponent();

            Random randomDice = new Random();

            theDice[0] = new Dices();
            theDice[1] = new Dices();
            theDice[2] = new Dices();
            theDice[3] = new Dices();
            theDice[4] = new Dices();
        }

        private void btn3ofKind_Click(object sender, EventArgs e)
        {
            if (CallCount > 0)
            {
                score = theScore.Calc4ofKind(theDice);

                if (score != 0)
                {
                    string message = "Your Dice total is " + score.ToString() + " . Continue?";
                    DialogResult result;

                    result = MessageBox.Show(message, "Three of a kind total", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        theScore.UpdateScore(score, false);
                    }
                    btnRoll.Show();
                }
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (CallCount < 3)
            {
                theDice[0].RollDice();
                theDice[1].RollDice();
                theDice[2].RollDice();
                theDice[3].RollDice();
                theDice[4].RollDice();

                call++;

                //theDice;

                if (CallCount == 0)
                {
                    theDice[0].HoldState = false;
                    theDice[1].HoldState = false;
                    theDice[2].HoldState = false;
                    theDice[3].HoldState = false;
                    theDice[4].HoldState = false;
                }
                if (CallCount == 3)
                {
                    theDice[0].HoldState = true;
                    theDice[1].HoldState = true;
                    theDice[2].HoldState = true;
                    theDice[3].HoldState = true;
                    theDice[4].HoldState = true;

                    btnRoll.Hide();
                    call = 0;
                    MessageBox.Show("Choose your score to continue!!!");

                }
            }
        }
        
        private void btn_keep1_1_Click(object sender, EventArgs e)
        {
            if (CallCount != 0)
            {
                if (theDice[0].HoldState == true)
                {
                    theDice[0].HoldState = false;
                }
                else
                {
                    theDice[0].HoldState = true;
                    btn_keep1_1.Text = "Free";
                }
            }
        }

        public void reset()
        {
            call = 0;
            scoreCount++;

            if (theScore.Bonus == true)
            {
                lbl_bonusP1.Text = "35";
            }
            else
            {
                lbl_bonusP1.Text = "0";
            }

            lbl_totalP1.Text = theScore.TotalScore.ToString();

            if (scoreCount == 14)
            {
               DialogResult result;

               result = MessageBox.Show("Your Score is " + lbl_totalP1.Text + ". Play again?", "End of Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  
            }
        }
    }
}

