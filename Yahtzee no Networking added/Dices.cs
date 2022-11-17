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
    public partial class Dices : UserControl
    {
        private BufferedGraphicsContext CurrentContext;

        private Random RandomRoll;
        private const int dotWidth = 12;
        private const int dotHeight = 12;

        public Dices(int seed)
        {
            InitializeComponent();
            InitializeRandomRoll(seed);
        }

        private bool DiceHoldState = true;

        public bool HoldState
        {
            set
            {
                DiceHoldState = value;
            }
            get
            {
                return DiceHoldState;
            }
        }

        private int rollNum;
        public int RollNumber
        {
            set
            {
                rollNum = value;
            }
            get
            {
                return rollNum;
            }
        }
        public void InitializeRandomRoll(int nSeed)
        {
            DateTime aTime = new DateTime(1000);
            aTime = DateTime.Now;
            nSeed += (int)(aTime.Millisecond);
            RandomRoll = new Random(nSeed);
        }

        private void createDice()
        {
            this.Name = "Dice";
            this.Size = new System.Drawing.Size(60, 60);
        }

        private void DrawDice(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            Pen redPen = new Pen(Color.Red, 1);

            //background
            Rectangle rectangle = new Rectangle(0, 0, this.Size.Width, this.Size.Height);

            SolidBrush whiteBrush = new SolidBrush(Color.White);
            g.FillRectangle(whiteBrush, rectangle);

            if (HoldState)
            {
                g.DrawRectangle(redPen, rectangle);
            }
            else
            {
                g.DrawRectangle(blackPen, rectangle);
            }

            switch (RollNumber)
            {
                case 1:
                    DrawOne(g);
                    rollNum = 1;
                    break;
                case 2:
                    DrawTwo(g);
                    rollNum = 2;
                    break;
                case 3:
                    DrawThree(g);
                    rollNum = 3;
                    break;
                case 4:
                    DrawFour(g);
                    rollNum = 4;
                    break;
                case 5:
                    DrawFive(g);
                    rollNum = 5;
                    break;
                case 6:
                    DrawSix(g);
                    rollNum = 6;
                    break;
            }
            //dispose after
            blackPen.Dispose();
            redPen.Dispose();
            whiteBrush.Dispose();
        }

        private void DrawDot(Graphics g, Point p)
        {
            SolidBrush solidBrush;

            if (HoldState)
            {
                solidBrush = new SolidBrush(Color.Red);
            }
            else
            {
                solidBrush = new SolidBrush(Color.Black);
            }
            g.FillEllipse(solidBrush, p.X, p.Y, dotWidth, dotHeight);
            solidBrush.Dispose();
        }

        //draw number
        private void DrawOne(Graphics g)
        {
            Rectangle rectangle = this.ClientRectangle;
            DrawDot(g, new Point((rectangle.Left + rectangle.Right - dotWidth) / 2, (rectangle.Top + rectangle.Bottom - dotHeight) / 2));
        }

        private void DrawTwo(Graphics g)
        {
            Rectangle rectangle = this.ClientRectangle;
            DrawDot(g, new Point((rectangle.Right - 3 - dotWidth), (rectangle.Top + 3))); // Top Right
            DrawDot(g, new Point((rectangle.Left + 3), (rectangle.Bottom - 3 - dotHeight))); // Bottom Left
        }

        private void DrawThree(Graphics g)
        { 
            DrawOne(g);
            DrawTwo(g);
        }

        private void DrawFour(Graphics g)
        {
            Rectangle rectangle = this.ClientRectangle;
            DrawTwo(g);
            DrawDot(g, new Point((rectangle.Left + 3), (rectangle.Top + 3))); // Top Left
            DrawDot(g, new Point((rectangle.Right - 3 - dotWidth), (rectangle.Bottom - 3 - dotHeight))); // Bottom Right
        }

        private void DrawFive(Graphics g)
        {
            DrawOne(g);
            DrawFour(g);
        }

        private void DrawSix(Graphics g)
        {
            DrawFour(g);
            Rectangle rectangle = this.ClientRectangle;
            DrawDot(g, new Point((rectangle.Left + rectangle.Right - dotWidth) / 2, (rectangle.Top + 3))); // Top Middle
            DrawDot(g, new Point((rectangle.Left + rectangle.Right - dotWidth) / 2, (rectangle.Bottom - 3 - dotWidth))); // Bottom Middle
        }

        public void RollDice()
        {
            if (!HoldState)
            {
                rollNum = RandomRoll.Next(1, 7);

            }
        }

        private void Dices_Paint(object sender, PaintEventArgs e)
        {
            CurrentContext = BufferedGraphicsManager.Current;
            System.Drawing.BufferedGraphics bg = CurrentContext.Allocate(CreateGraphics(), ClientRectangle);
            bg.Graphics.Clear(SystemColors.Window);


            createDice();
            RollDice();
            DrawDice(bg.Graphics);
            bg.Render();
        }
    }
}
