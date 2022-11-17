using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_test
{
    public partial class Form1 : Form
    {
        List<Dice> Player1Dice = new List<Dice>();
        List<Dice> Player2Dice = new List<Dice>();
        List<Dice> Player3Dice = new List<Dice>();
        List<Dice> Player4Dice = new List<Dice>();

        Random random = new Random();
        int PlayerTurn = 0;

        //int[] player = new int[5];
        //int[] dice;
        ////int player[1] = new dice[1];
        //int player1, player2, player3, player4;
        int diceVal, diceVal2, diceVal3, diceVal4, diceVal5, diceVal6;
        private bool keep = false;

        private int call, score;
        private int scoreCount = 0;

        private ScoreCalculation theScore = new ScoreCalculation();

        private void btn3ofKind_Click(object sender, EventArgs e)
        {
            if (CallCount > 0)
            {
                score = theScore.Calc4ofKind(score);

                if (score != 0)
                {
                    string message = "Your Dice total is " + score.ToString() + " . Continue?";
                    DialogResult result;

                    result = MessageBox.Show(message, "Three of a kind total", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                    if (result == DialogResult.Yes)
                    {
                        theScore.UpdateScore(score, false);
                        
                    }
                }
            }
        }

        private void btn_keep1_1_Click(object sender, EventArgs e)
        {
            if (CallCount != 0)
            {
               if (keep == true) //we keep the thingi and dont run the dice
               {
                    //pbx_dice1_1.Image = ;  how to retain the value of the random picturebox here?
               }
               else //keep it running
               {
                    btn_keep1_1.Text = "Free";
               }
            }
        }


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
            btnRoll2.Hide();
            btnRoll3.Hide();
            btnRoll4.Hide();

            for (int i = 0; i < 6; i++)
            {
                Player1Dice.Add(new Dice());
                Player2Dice.Add(new Dice());
                Player3Dice.Add(new Dice());
                Player4Dice.Add(new Dice());
            }
         }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            player1 = 1;
            if (player1 == 1)
            {
                pbx_dice2_1.Hide();
                pbx_dice2_2.Hide();
                pbx_dice2_3.Hide();
                pbx_dice2_4.Hide();
                pbx_dice2_5.Hide();

                pbx_dice3_1.Hide();
                pbx_dice3_2.Hide();
                pbx_dice3_3.Hide();
                pbx_dice3_4.Hide();
                pbx_dice3_5.Hide();

                pbx_dice4_1.Hide();
                pbx_dice4_2.Hide();
                pbx_dice4_3.Hide();
                pbx_dice4_4.Hide();
                pbx_dice4_5.Hide();

                pbx_dice1_1.Show();
                pbx_dice1_2.Show();
                pbx_dice1_3.Show();
                pbx_dice1_4.Show();
                pbx_dice1_5.Show();

                if (CallCount < 3)
                {
                    callDices();

                    call++;

                    if (CallCount == 3)
                    {
                        btnRoll.Hide();
                        call = 0;
                        if (keep == true)
                        {
                            theScore.AddAllDice(diceVal);
                            theScore.UpdateScore(score, false);
                        }
                        
                        MessageBox.Show("Choose your score to continue!!!");
                        
                        
                        pbx_dice1_1.Hide();
                        pbx_dice1_2.Hide();
                        pbx_dice1_3.Hide();
                        pbx_dice1_4.Hide();
                        pbx_dice1_5.Hide();
                    }
                }
            }
        }

        private void btnRoll2_Click(object sender, EventArgs e)
        {
            player2 = 1;
            if(player2 == 1)
            {
                btnRoll2.Show();
                pbx_dice2_1.Show();
                pbx_dice2_2.Show();
                pbx_dice2_3.Show();
                pbx_dice2_4.Show();
                pbx_dice2_5.Show();
                if (CallCount >= 3)
                {
                    if (CallCount == 3)
                    {
                        btnRoll2.Hide();
                        call = 0;
                        MessageBox.Show("Choose your score to continue!!!");
                        btnRoll3.Show();
                        pbx_dice2_1.Hide();
                        pbx_dice2_2.Hide();
                        pbx_dice2_3.Hide();
                        pbx_dice2_4.Hide();
                        pbx_dice2_5.Hide();
                    }
                }
                else
                {
                    callDices();
                    call++;
                }
            }
           
        }

        private void btnRoll3_Click(object sender, EventArgs e)
        {
            player3 = 1;
            if (player3 == 1)
            {
                pbx_dice3_1.Show();
                pbx_dice3_2.Show();
                pbx_dice3_3.Show();
                pbx_dice3_4.Show();
                pbx_dice3_5.Show();
                if (CallCount >= 3)
                {
                    if (CallCount == 3)
                    {
                        btnRoll3.Hide();
                        call = 0;
                        MessageBox.Show("Choose your score to continue!!!");
                        btnRoll4.Show();
                        pbx_dice3_1.Hide();
                        pbx_dice3_2.Hide();
                        pbx_dice3_3.Hide();
                        pbx_dice3_4.Hide();
                        pbx_dice3_5.Hide();
                    }
                }
                else
                {
                    callDices();
                    call++;
                }
            }        
        }

        private void btnRoll4_Click(object sender, EventArgs e)
        {
            player4 = 1;
            if (player4 == 1)
            {
                pbx_dice4_1.Show();
                pbx_dice4_2.Show();
                pbx_dice4_3.Show();
                pbx_dice4_4.Show();
                pbx_dice4_5.Show();
                if (CallCount >= 3)
                {
                    if (CallCount == 3)
                    {
                        btnRoll4.Hide();
                        call = 0;
                        MessageBox.Show("Choose your score to continue!!!");
                        btnRoll.Show();
                        pbx_dice4_1.Hide();
                        pbx_dice4_2.Hide();
                        pbx_dice4_3.Hide();
                        pbx_dice4_4.Hide();
                        pbx_dice4_5.Hide();
                    }

                }
                else
                {
                    callDices();
                    call++;
                }
            }
        }

        class Dice
        {
            int Side = 0;
            bool Keep = false;
            Random RandomGenerator = new Random();

            public void Roll()
            {
                if (!Keep)
                {
                    Side = RandomGenerator.Next(1, 7);
                }
            }
        }

        void FillPictureBox(PictureBox PB, int DiceNumber)
        {
            PB.Image = Image.FromFile("Dice" + DiceNumber.ToString() + ".png");
        }

        public void callDices()
        {
            //player 1 dices
            //for (int i = 0; i < 6; i++) //1-5 dices
            //{
            //    switch (PlayerTurn)
            //    {
            //        case 1:
            //            Player1Dice[i].Roll();

                        
            //            break;
            //        case 2:
            //            Player2Dice[i].Roll();

            //            break;
            //        case 3:
            //            Player3Dice[i].Roll();

            //            break;
            //        case 4:
            //            Player4Dice[i].Roll();

            //            break;
            //    }
            //}

            if (keep) //keep is false
            {
                switch (dice1_1)
                {
                    case 1:
                        pbx_dice1_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                        diceVal = 1;
                        break;
                    case 2:
                        pbx_dice1_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                        diceVal = 2;
                        break;
                    case 3:
                        pbx_dice1_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                        diceVal = 3;
                        break;
                    case 4:
                        pbx_dice1_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                        diceVal = 4;
                        break;
                    case 5:
                        pbx_dice1_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                        diceVal = 5;
                        break;
                    case 6:
                        pbx_dice1_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                        diceVal = 6;
                        break;
                }
            }


            switch (dice1_1)
            {
                case 1:
                    pbx_dice1_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal2 = 1;
                    break;
                case 2:
                    pbx_dice1_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal2 = 2;
                    break;
                case 3:
                    pbx_dice1_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal2 = 3;
                    break;
                case 4:
                    pbx_dice1_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal2 = 4;
                    break;
                case 5:
                    pbx_dice1_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal2 = 5;
                    break;
                case 6:
                    pbx_dice1_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal2 = 6;
                    break;
            }

            switch (dice1_1)
            {
                case 1:
                    pbx_dice1_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal3 = 1;
                    break;
                case 2:
                    pbx_dice1_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal3 = 2;
                    break;
                case 3:
                    pbx_dice1_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal3 = 3;
                    break;
                case 4:
                    pbx_dice1_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal3 = 4;
                    break;
                case 5:
                    pbx_dice1_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal3 = 5;
                    break;
                case 6:
                    pbx_dice1_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal3 = 6;
                    break;
            }

            switch (dice1_1)
            {
                case 1:
                    pbx_dice1_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal4 = 1;
                    break;
                case 2:
                    pbx_dice1_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal4 = 2;
                    break;
                case 3:
                    pbx_dice1_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal4 = 3;
                    break;
                case 4:
                    pbx_dice1_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal4 = 4;
                    break;
                case 5:
                    pbx_dice1_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal4 = 5;
                    break;
                case 6:
                    pbx_dice1_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal4 = 6;
                    break;
            }

            switch (dice1_1)
            {
                case 1:
                    pbx_dice1_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal5 = 1;
                    break;
                case 2:
                    pbx_dice1_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal5 = 2;
                    break;
                case 3:
                    pbx_dice1_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal5 = 3;
                    break;
                case 4:
                    pbx_dice1_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal5 = 4;
                    break;
                case 5:
                    pbx_dice1_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal5 = 5;
                    break;
                case 6:
                    pbx_dice1_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal5 = 6;
                    break;
            }

            //player 2 dices
            dice2_1 = random.Next(1, 7);
            dice2_2 = random.Next(1, 7);
            dice2_3 = random.Next(1, 7);
            dice2_4 = random.Next(1, 7);
            dice2_5 = random.Next(1, 7);

            switch (dice2_1)
            {
                case 1:
                    pbx_dice2_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal = 1;
                    break;
                case 2:
                    pbx_dice2_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal = 2;
                    break;
                case 3:
                    pbx_dice2_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal = 3;
                    break;
                case 4:
                    pbx_dice2_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal = 4;
                    break;
                case 5:
                    pbx_dice2_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal = 5;
                    break;
                case 6:
                    pbx_dice2_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal = 6;
                    break;
            }

            switch (dice2_2)
            {
                case 1:
                    pbx_dice2_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal2 = 1;
                    break;
                case 2:
                    pbx_dice2_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal2 = 2;
                    break;
                case 3:
                    pbx_dice2_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal2 = 3;
                    break;
                case 4:
                    pbx_dice2_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal2 = 4;
                    break;
                case 5:
                    pbx_dice2_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal2 = 5;
                    break;
                case 6:
                    pbx_dice2_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal2 = 6;
                    break;
            }

            switch (dice2_3)
            {
                case 1:
                    pbx_dice2_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal3 = 1;
                    break;
                case 2:
                    pbx_dice2_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal3 = 2;
                    break;
                case 3:
                    pbx_dice2_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal3 = 3;
                    break;
                case 4:
                    pbx_dice2_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal3 = 4;
                    break;
                case 5:
                    pbx_dice2_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal3 = 5;
                    break;
                case 6:
                    pbx_dice2_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal3 = 6;
                    break;
            }

            switch (dice2_4)
            {
                case 1:
                    pbx_dice2_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal4 = 1;
                    break;
                case 2:
                    pbx_dice2_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal4 = 2;
                    break;
                case 3:
                    pbx_dice2_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal4 = 3;
                    break;
                case 4:
                    pbx_dice2_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal4 = 4;
                    break;
                case 5:
                    pbx_dice2_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal4 = 5;
                    break;
                case 6:
                    pbx_dice2_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal4 = 6;
                    break;
            }

            switch (dice2_5)
            {
                case 1:
                    pbx_dice2_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal5 = 1;
                    break;
                case 2:
                    pbx_dice2_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal5 = 2;
                    break;
                case 3:
                    pbx_dice2_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal5 = 3;
                    break;
                case 4:
                    pbx_dice2_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal5 = 4;
                    break;
                case 5:
                    pbx_dice2_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal5 = 5;
                    break;
                case 6:
                    pbx_dice2_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal5 = 6;
                    break;
            }

            //player 3 dices
            dice3_1 = random.Next(1, 7);
            dice3_2 = random.Next(1, 7);
            dice3_3 = random.Next(1, 7);
            dice3_4 = random.Next(1, 7);
            dice3_5 = random.Next(1, 7);

            switch (dice3_1)
            {
                case 1:
                    pbx_dice3_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal = 1;
                    break;
                case 2:
                    pbx_dice3_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal = 2;
                    break;
                case 3:
                    pbx_dice3_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal = 3;
                    break;
                case 4:
                    pbx_dice3_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal = 4;
                    break;
                case 5:
                    pbx_dice3_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal = 5;
                    break;
                case 6:
                    pbx_dice3_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal = 6;
                    break;
            }

            switch (dice3_2)
            {
                case 1:
                    pbx_dice3_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal2 = 1;
                    break;
                case 2:
                    pbx_dice3_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal2 = 2;
                    break;
                case 3:
                    pbx_dice3_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal2 = 3;
                    break;
                case 4:
                    pbx_dice3_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal2 = 4;
                    break;
                case 5:
                    pbx_dice3_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal2 = 5;
                    break;
                case 6:
                    pbx_dice3_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal2 = 6;
                    break;
            }

            switch (dice3_3)
            {
                case 1:
                    pbx_dice3_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal3 = 1;
                    break;
                case 2:
                    pbx_dice3_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal3 = 2;
                    break;
                case 3:
                    pbx_dice3_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal3 = 3;
                    break;
                case 4:
                    pbx_dice3_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal3 = 4;
                    break;
                case 5:
                    pbx_dice3_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal3 = 5;
                    break;
                case 6:
                    pbx_dice3_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal3 = 6;
                    break;
            }

            switch (dice3_4)
            {
                case 1:
                    pbx_dice3_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal4 = 1;
                    break;
                case 2:
                    pbx_dice3_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal4 = 2;
                    break;
                case 3:
                    pbx_dice3_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal4 = 3;
                    break;
                case 4:
                    pbx_dice3_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal4 = 4;
                    break;
                case 5:
                    pbx_dice3_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal4 = 5;
                    break;
                case 6:
                    pbx_dice3_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal4 = 6;
                    break;
            }

            switch (dice3_5)
            {
                case 1:
                    pbx_dice3_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal5 = 1;
                    break;
                case 2:
                    pbx_dice3_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal5 = 2;
                    break;
                case 3:
                    pbx_dice3_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal5 = 3;
                    break;
                case 4:
                    pbx_dice3_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal5 = 4;
                    break;
                case 5:
                    pbx_dice3_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal5 = 5;
                    break;
                case 6:
                    pbx_dice3_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal5 = 6;
                    break;
            }

            //player 4 dices
            dice4_1 = random.Next(1, 7);
            dice4_2 = random.Next(1, 7);
            dice4_3 = random.Next(1, 7);
            dice4_4 = random.Next(1, 7);
            dice4_5 = random.Next(1, 7);

            switch (dice4_1)
            {

                case 1:
                    pbx_dice4_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal = 1;
                    break;
                case 2:
                    pbx_dice4_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal = 2;
                    break;
                case 3:
                    pbx_dice4_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal = 3;
                    break;
                case 4:
                    pbx_dice4_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal = 4;
                    break;
                case 5:
                    pbx_dice4_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal = 5;
                    break;
                case 6:
                    pbx_dice4_1.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal = 6;
                    break;
            }

            switch (dice4_2)
            {
                case 1:
                    pbx_dice4_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal2 = 1;
                    break;
                case 2:
                    pbx_dice4_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal2 = 2;
                    break;
                case 3:
                    pbx_dice4_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal2 = 3;
                    break;
                case 4:
                    pbx_dice4_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal2 = 4;
                    break;
                case 5:
                    pbx_dice4_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal2 = 5;
                    break;
                case 6:
                    pbx_dice4_2.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal2 = 6;
                    break;
            }

            switch (dice4_3)
            {
                case 1:
                    pbx_dice4_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal3 = 1;
                    break;
                case 2:
                    pbx_dice4_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal3 = 2;
                    break;
                case 3:
                    pbx_dice4_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal3 = 3;
                    break;
                case 4:
                    pbx_dice4_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal3 = 4;
                    break;
                case 5:
                    pbx_dice4_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal3 = 5;
                    break;
                case 6:
                    pbx_dice4_3.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal3 = 6;
                    break;
            }

            switch (dice4_4)
            {
                case 1:
                    pbx_dice4_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal4 = 1;
                    break;
                case 2:
                    pbx_dice4_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal4 = 2;
                    break;
                case 3:
                    pbx_dice4_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal4 = 3;
                    break;
                case 4:
                    pbx_dice4_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal4 = 4;
                    break;
                case 5:
                    pbx_dice4_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal4 = 5;
                    break;
                case 6:
                    pbx_dice4_4.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal4 = 6;
                    break;
            }

            switch (dice4_5)
            {
                case 1:
                    pbx_dice4_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice1.PNG";
                    diceVal5 = 1;
                    break;
                case 2:
                    pbx_dice4_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice2.PNG";
                    diceVal5 = 2;
                    break;
                case 3:
                    pbx_dice4_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice3.PNG";
                    diceVal5 = 3;
                    break;
                case 4:
                    pbx_dice4_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice4.PNG";
                    diceVal5 = 4;
                    break;
                case 5:
                    pbx_dice4_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice5.PNG";
                    diceVal5 = 5;
                    break;
                case 6:
                    pbx_dice4_5.ImageLocation = "C:\\Users\\luizz\\source\\repos\\Yahtzee test\\bin\\Debug\\dice6.PNG";
                    diceVal5 = 6;
                    break;
            }
        }

        public void reset()
        {
            call = 0;
            scoreCount++;

            if(theScore.Bonus == true)
            {
                //player 1
                if (player1 == 1)
                {
                    lbl_bonusP1.Text = "35";
                }
                else
                {
                    lbl_bonusP1.Text = "0";
                }
                //player2
                if (player2 == 1)
                {
                    lbl_bonusP2.Text = "35";
                }
                else
                {
                    lbl_bonusP2.Text = "0";
                }
                //player3
                if (player3 == 1)
                {
                    lbl_bonusP3.Text = "35";
                }
                else
                {
                    lbl_bonusP3.Text = "0";
                }
                //player 4
                if (player4 == 1)
                {
                    lbl_bonusP4.Text = "35";
                }
                else
                {
                    lbl_bonusP4.Text = "0";
                }

                lbl_totalP1.Text = theScore.TotalScore.ToString();

                if (scoreCount == 14)
                {
                    DialogResult result;

                    //player 1
                    if (player1 == 1)
                    {
                        result = MessageBox.Show("Your Score is " + lbl_totalP1.Text + ". Play again?", "End of Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    
                    //player2
                    if (player2 == 1)
                    {
                        result = MessageBox.Show("Your Score is " + lbl_totalP2.Text + ". Play again?", "End of Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    //player3
                    if (player3 == 1)
                    {
                        result = MessageBox.Show("Your Score is " + lbl_totalP3.Text + ". Play again?", "End of Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    //player 4
                    if (player4 == 1)
                    {
                        result = MessageBox.Show("Your Score is " + lbl_totalP4.Text + ". Play again?", "End of Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }

                }
            }
        }
    }
}
