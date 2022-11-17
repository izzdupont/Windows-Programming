using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_2
{
    class ScoreCalculation
    {

        private int sum, count;
        bool FourofKind = false;
        bool ThreeofKind = false;

        //total all score
        private int Total = 0;
        public int TotalScore
        {
            get
            {
                return Total;
            }
        }

        //total 1-6
        private int UpperSTotal = 0;
        public int UpperTotalScore
        {
            get
            {
                return UpperSTotal;
            }
        }

        //total anything other than 1-6
        private int LowerSTotal = 0;
        public int LowerTotalScore
        {
            get
            {
                return LowerSTotal;
            }
        }

        //upper bonus
        public bool Bonus = false;

        //reset all scores
        public void ResetAll()
        {
            Total = 0;
            UpperSTotal = 0;
            LowerSTotal = 0;
            Bonus = false;
        }

        //claculating score
        public void UpdateScore(int Score, bool upperScore)
        {
            //if they score 1-6
            if (upperScore == true)
            {
                UpperSTotal += Score;
                //if upper total score >= 63, give bonus
                if (UpperSTotal >= 63)
                {
                    Bonus = true;
                }
            }
            //score other than 1-6
            else
            {
                LowerSTotal += Score;
            }
            Total = 0;
            Total += UpperSTotal;
            if (Bonus == true)
            {
                Total += 35;
            }
            Total += LowerSTotal;
        }

        public int AddAllDice(int DiceVal)
        {
            sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += DiceVal;
            }
            return sum;
        }

        public int Calc3ofKind(Dices[] playerDice)
        {
            sum = 0;

            for (int i = 1; i <= 6; i++)
            {
                count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (playerDice[j].RollNumber == i)
                    {
                        count++;
                    }
                    //for anything that is 3,4 or 5 kind
                    if (count > 2)
                    {
                        ThreeofKind = true;
                    }
                }
            }

            if (ThreeofKind)
            {
                for (int k = 0; k < 5; k++)
                {
                    sum += playerDice[k].RollNumber;
                }
            }
            return sum;
        }

        public int Calc4ofKind(Dices[] playerDice)
        {
            sum = 0;

            for (int i = 1; i <= 6; i++)
            {
                count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (playerDice[j].RollNumber == i)
                    {
                        count++;
                    }
                    //for anything that is 4 or 5 kind
                    if (count > 3)
                    {
                        FourofKind = true;
                    }
                }
            }

            if (FourofKind)
            {
                for (int k = 0; k < 5; k++)
                {
                    sum += playerDice[k].RollNumber;
                }
            }
            return sum;
        }

    }
}

