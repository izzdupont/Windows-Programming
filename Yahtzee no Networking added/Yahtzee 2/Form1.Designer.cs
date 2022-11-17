
namespace Yahtzee_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_keep1_5 = new System.Windows.Forms.Button();
            this.btn_keep1_4 = new System.Windows.Forms.Button();
            this.btn_keep1_3 = new System.Windows.Forms.Button();
            this.btn_keep1_2 = new System.Windows.Forms.Button();
            this.btn_keep1_1 = new System.Windows.Forms.Button();
            this.lbl_player1 = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btn_Ones = new System.Windows.Forms.Button();
            this.btnTwos = new System.Windows.Forms.Button();
            this.btnThrees = new System.Windows.Forms.Button();
            this.btnFours = new System.Windows.Forms.Button();
            this.btnFives = new System.Windows.Forms.Button();
            this.btnSixes = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnBonus = new System.Windows.Forms.Button();
            this.btn3ofKind = new System.Windows.Forms.Button();
            this.btn4ofKind = new System.Windows.Forms.Button();
            this.btnFullH = new System.Windows.Forms.Button();
            this.btnSmallS = new System.Windows.Forms.Button();
            this.btnLargeS = new System.Windows.Forms.Button();
            this.btnChance = new System.Windows.Forms.Button();
            this.btnYAHTZEE = new System.Windows.Forms.Button();
            this.lbl_3ofkindScoreP1 = new System.Windows.Forms.Label();
            this.lbl_bonusP1 = new System.Windows.Forms.Label();
            this.lbl_totalP1 = new System.Windows.Forms.Label();
            this.dices5 = new Yahtzee_2.Dices();
            this.dices4 = new Yahtzee_2.Dices();
            this.dices3 = new Yahtzee_2.Dices();
            this.dices2 = new Yahtzee_2.Dices();
            this.dices1 = new Yahtzee_2.Dices();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1029, 611);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.dices5);
            this.panel1.Controls.Add(this.dices4);
            this.panel1.Controls.Add(this.dices3);
            this.panel1.Controls.Add(this.dices2);
            this.panel1.Controls.Add(this.dices1);
            this.panel1.Controls.Add(this.btn_keep1_5);
            this.panel1.Controls.Add(this.btn_keep1_4);
            this.panel1.Controls.Add(this.btn_keep1_3);
            this.panel1.Controls.Add(this.btn_keep1_2);
            this.panel1.Controls.Add(this.btn_keep1_1);
            this.panel1.Controls.Add(this.lbl_player1);
            this.panel1.Controls.Add(this.btnRoll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 611);
            this.panel1.TabIndex = 0;
            // 
            // btn_keep1_5
            // 
            this.btn_keep1_5.Location = new System.Drawing.Point(564, 334);
            this.btn_keep1_5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_keep1_5.Name = "btn_keep1_5";
            this.btn_keep1_5.Size = new System.Drawing.Size(80, 34);
            this.btn_keep1_5.TabIndex = 38;
            this.btn_keep1_5.Text = "Keep";
            this.btn_keep1_5.UseVisualStyleBackColor = true;
            // 
            // btn_keep1_4
            // 
            this.btn_keep1_4.Location = new System.Drawing.Point(430, 334);
            this.btn_keep1_4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_keep1_4.Name = "btn_keep1_4";
            this.btn_keep1_4.Size = new System.Drawing.Size(80, 34);
            this.btn_keep1_4.TabIndex = 37;
            this.btn_keep1_4.Text = "Keep";
            this.btn_keep1_4.UseVisualStyleBackColor = true;
            // 
            // btn_keep1_3
            // 
            this.btn_keep1_3.Location = new System.Drawing.Point(290, 334);
            this.btn_keep1_3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_keep1_3.Name = "btn_keep1_3";
            this.btn_keep1_3.Size = new System.Drawing.Size(80, 34);
            this.btn_keep1_3.TabIndex = 36;
            this.btn_keep1_3.Text = "Keep";
            this.btn_keep1_3.UseVisualStyleBackColor = true;
            // 
            // btn_keep1_2
            // 
            this.btn_keep1_2.Location = new System.Drawing.Point(157, 334);
            this.btn_keep1_2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_keep1_2.Name = "btn_keep1_2";
            this.btn_keep1_2.Size = new System.Drawing.Size(80, 34);
            this.btn_keep1_2.TabIndex = 35;
            this.btn_keep1_2.Text = "Keep";
            this.btn_keep1_2.UseVisualStyleBackColor = true;
            // 
            // btn_keep1_1
            // 
            this.btn_keep1_1.Location = new System.Drawing.Point(28, 334);
            this.btn_keep1_1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_keep1_1.Name = "btn_keep1_1";
            this.btn_keep1_1.Size = new System.Drawing.Size(80, 34);
            this.btn_keep1_1.TabIndex = 34;
            this.btn_keep1_1.Text = "Keep";
            this.btn_keep1_1.UseVisualStyleBackColor = true;
            this.btn_keep1_1.Click += new System.EventHandler(this.btn_keep1_1_Click);
            // 
            // lbl_player1
            // 
            this.lbl_player1.AutoSize = true;
            this.lbl_player1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_player1.Location = new System.Drawing.Point(23, 21);
            this.lbl_player1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_player1.Name = "lbl_player1";
            this.lbl_player1.Size = new System.Drawing.Size(102, 29);
            this.lbl_player1.TabIndex = 12;
            this.lbl_player1.Text = "Player 1:";
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(544, 440);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(100, 28);
            this.btnRoll.TabIndex = 11;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(679, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 611);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "SCORE!!";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.88591F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.77852F));
            this.tableLayoutPanel2.Controls.Add(this.lblTotal, 0, 15);
            this.tableLayoutPanel2.Controls.Add(this.btn_Ones, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTwos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnThrees, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnFours, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnFives, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnSixes, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnSum, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnBonus, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn3ofKind, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btn4ofKind, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.btnFullH, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.btnSmallS, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.btnLargeS, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.btnChance, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.btnYAHTZEE, 0, 14);
            this.tableLayoutPanel2.Controls.Add(this.lbl_3ofkindScoreP1, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.lbl_bonusP1, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lbl_totalP1, 1, 15);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 60);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 16;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(332, 464);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotal.Font = new System.Drawing.Font("Dubai", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 438);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(207, 24);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total Score";
            // 
            // btn_Ones
            // 
            this.btn_Ones.AutoSize = true;
            this.btn_Ones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ones.Location = new System.Drawing.Point(2, 2);
            this.btn_Ones.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Ones.Name = "btn_Ones";
            this.btn_Ones.Size = new System.Drawing.Size(215, 26);
            this.btn_Ones.TabIndex = 17;
            this.btn_Ones.Text = "Ones";
            this.btn_Ones.UseVisualStyleBackColor = true;
            // 
            // btnTwos
            // 
            this.btnTwos.AutoSize = true;
            this.btnTwos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTwos.Location = new System.Drawing.Point(2, 30);
            this.btnTwos.Margin = new System.Windows.Forms.Padding(0);
            this.btnTwos.Name = "btnTwos";
            this.btnTwos.Size = new System.Drawing.Size(215, 26);
            this.btnTwos.TabIndex = 18;
            this.btnTwos.Text = "Twos";
            this.btnTwos.UseVisualStyleBackColor = true;
            // 
            // btnThrees
            // 
            this.btnThrees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThrees.Location = new System.Drawing.Point(2, 58);
            this.btnThrees.Margin = new System.Windows.Forms.Padding(0);
            this.btnThrees.Name = "btnThrees";
            this.btnThrees.Size = new System.Drawing.Size(215, 26);
            this.btnThrees.TabIndex = 19;
            this.btnThrees.Text = "Threes";
            this.btnThrees.UseVisualStyleBackColor = true;
            // 
            // btnFours
            // 
            this.btnFours.AutoSize = true;
            this.btnFours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFours.Location = new System.Drawing.Point(2, 86);
            this.btnFours.Margin = new System.Windows.Forms.Padding(0);
            this.btnFours.Name = "btnFours";
            this.btnFours.Size = new System.Drawing.Size(215, 26);
            this.btnFours.TabIndex = 20;
            this.btnFours.Text = "Fours";
            this.btnFours.UseVisualStyleBackColor = true;
            // 
            // btnFives
            // 
            this.btnFives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFives.Location = new System.Drawing.Point(2, 114);
            this.btnFives.Margin = new System.Windows.Forms.Padding(0);
            this.btnFives.Name = "btnFives";
            this.btnFives.Size = new System.Drawing.Size(215, 26);
            this.btnFives.TabIndex = 21;
            this.btnFives.Text = "Fives";
            this.btnFives.UseVisualStyleBackColor = true;
            // 
            // btnSixes
            // 
            this.btnSixes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSixes.Location = new System.Drawing.Point(2, 142);
            this.btnSixes.Margin = new System.Windows.Forms.Padding(0);
            this.btnSixes.Name = "btnSixes";
            this.btnSixes.Size = new System.Drawing.Size(215, 26);
            this.btnSixes.TabIndex = 22;
            this.btnSixes.Text = "Sixes";
            this.btnSixes.UseVisualStyleBackColor = true;
            // 
            // btnSum
            // 
            this.btnSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSum.Location = new System.Drawing.Point(2, 170);
            this.btnSum.Margin = new System.Windows.Forms.Padding(0);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(215, 26);
            this.btnSum.TabIndex = 23;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // btnBonus
            // 
            this.btnBonus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBonus.Location = new System.Drawing.Point(2, 198);
            this.btnBonus.Margin = new System.Windows.Forms.Padding(0);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(215, 26);
            this.btnBonus.TabIndex = 24;
            this.btnBonus.Text = "Bonus";
            this.btnBonus.UseVisualStyleBackColor = true;
            // 
            // btn3ofKind
            // 
            this.btn3ofKind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3ofKind.Location = new System.Drawing.Point(2, 226);
            this.btn3ofKind.Margin = new System.Windows.Forms.Padding(0);
            this.btn3ofKind.Name = "btn3ofKind";
            this.btn3ofKind.Size = new System.Drawing.Size(215, 26);
            this.btn3ofKind.TabIndex = 25;
            this.btn3ofKind.Text = "3 of Kind";
            this.btn3ofKind.UseVisualStyleBackColor = true;
            // 
            // btn4ofKind
            // 
            this.btn4ofKind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4ofKind.Location = new System.Drawing.Point(2, 254);
            this.btn4ofKind.Margin = new System.Windows.Forms.Padding(0);
            this.btn4ofKind.Name = "btn4ofKind";
            this.btn4ofKind.Size = new System.Drawing.Size(215, 26);
            this.btn4ofKind.TabIndex = 26;
            this.btn4ofKind.Text = "4 of Kind";
            this.btn4ofKind.UseVisualStyleBackColor = true;
            // 
            // btnFullH
            // 
            this.btnFullH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFullH.Location = new System.Drawing.Point(2, 282);
            this.btnFullH.Margin = new System.Windows.Forms.Padding(0);
            this.btnFullH.Name = "btnFullH";
            this.btnFullH.Size = new System.Drawing.Size(215, 26);
            this.btnFullH.TabIndex = 27;
            this.btnFullH.Text = "Full House";
            this.btnFullH.UseVisualStyleBackColor = true;
            // 
            // btnSmallS
            // 
            this.btnSmallS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSmallS.Location = new System.Drawing.Point(2, 310);
            this.btnSmallS.Margin = new System.Windows.Forms.Padding(0);
            this.btnSmallS.Name = "btnSmallS";
            this.btnSmallS.Size = new System.Drawing.Size(215, 26);
            this.btnSmallS.TabIndex = 28;
            this.btnSmallS.Text = "Small Straight";
            this.btnSmallS.UseVisualStyleBackColor = true;
            // 
            // btnLargeS
            // 
            this.btnLargeS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLargeS.Location = new System.Drawing.Point(2, 338);
            this.btnLargeS.Margin = new System.Windows.Forms.Padding(0);
            this.btnLargeS.Name = "btnLargeS";
            this.btnLargeS.Size = new System.Drawing.Size(215, 26);
            this.btnLargeS.TabIndex = 29;
            this.btnLargeS.Text = "Large Straight";
            this.btnLargeS.UseVisualStyleBackColor = true;
            // 
            // btnChance
            // 
            this.btnChance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChance.Location = new System.Drawing.Point(2, 366);
            this.btnChance.Margin = new System.Windows.Forms.Padding(0);
            this.btnChance.Name = "btnChance";
            this.btnChance.Size = new System.Drawing.Size(215, 26);
            this.btnChance.TabIndex = 30;
            this.btnChance.Text = "Chance";
            this.btnChance.UseVisualStyleBackColor = true;
            // 
            // btnYAHTZEE
            // 
            this.btnYAHTZEE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYAHTZEE.ForeColor = System.Drawing.Color.Maroon;
            this.btnYAHTZEE.Location = new System.Drawing.Point(2, 394);
            this.btnYAHTZEE.Margin = new System.Windows.Forms.Padding(0);
            this.btnYAHTZEE.Name = "btnYAHTZEE";
            this.btnYAHTZEE.Size = new System.Drawing.Size(215, 26);
            this.btnYAHTZEE.TabIndex = 31;
            this.btnYAHTZEE.Text = "YAHTZEE";
            this.btnYAHTZEE.UseVisualStyleBackColor = true;
            // 
            // lbl_3ofkindScoreP1
            // 
            this.lbl_3ofkindScoreP1.AutoSize = true;
            this.lbl_3ofkindScoreP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_3ofkindScoreP1.Location = new System.Drawing.Point(222, 226);
            this.lbl_3ofkindScoreP1.Name = "lbl_3ofkindScoreP1";
            this.lbl_3ofkindScoreP1.Size = new System.Drawing.Size(105, 26);
            this.lbl_3ofkindScoreP1.TabIndex = 32;
            // 
            // lbl_bonusP1
            // 
            this.lbl_bonusP1.AutoSize = true;
            this.lbl_bonusP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_bonusP1.Location = new System.Drawing.Point(222, 198);
            this.lbl_bonusP1.Name = "lbl_bonusP1";
            this.lbl_bonusP1.Size = new System.Drawing.Size(105, 26);
            this.lbl_bonusP1.TabIndex = 34;
            // 
            // lbl_totalP1
            // 
            this.lbl_totalP1.AutoSize = true;
            this.lbl_totalP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalP1.Location = new System.Drawing.Point(222, 422);
            this.lbl_totalP1.Name = "lbl_totalP1";
            this.lbl_totalP1.Size = new System.Drawing.Size(105, 40);
            this.lbl_totalP1.TabIndex = 40;
            // 
            // dices5
            // 
            this.dices5.HoldState = true;
            this.dices5.Location = new System.Drawing.Point(580, 264);
            this.dices5.Name = "dices5";
            this.dices5.RollNumber = 0;
            this.dices5.Size = new System.Drawing.Size(48, 48);
            this.dices5.TabIndex = 43;
            // 
            // dices4
            // 
            this.dices4.HoldState = true;
            this.dices4.Location = new System.Drawing.Point(445, 264);
            this.dices4.Name = "dices4";
            this.dices4.RollNumber = 0;
            this.dices4.Size = new System.Drawing.Size(48, 48);
            this.dices4.TabIndex = 42;
            // 
            // dices3
            // 
            this.dices3.HoldState = true;
            this.dices3.Location = new System.Drawing.Point(304, 264);
            this.dices3.Name = "dices3";
            this.dices3.RollNumber = 0;
            this.dices3.Size = new System.Drawing.Size(48, 48);
            this.dices3.TabIndex = 41;
            // 
            // dices2
            // 
            this.dices2.HoldState = true;
            this.dices2.Location = new System.Drawing.Point(171, 264);
            this.dices2.Name = "dices2";
            this.dices2.RollNumber = 0;
            this.dices2.Size = new System.Drawing.Size(48, 48);
            this.dices2.TabIndex = 40;
            // 
            // dices1
            // 
            this.dices1.HoldState = true;
            this.dices1.Location = new System.Drawing.Point(46, 264);
            this.dices1.Name = "dices1";
            this.dices1.RollNumber = 0;
            this.dices1.Size = new System.Drawing.Size(48, 48);
            this.dices1.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_keep1_5;
        private System.Windows.Forms.Button btn_keep1_4;
        private System.Windows.Forms.Button btn_keep1_3;
        private System.Windows.Forms.Button btn_keep1_2;
        private System.Windows.Forms.Button btn_keep1_1;
        private System.Windows.Forms.Label lbl_player1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btn_Ones;
        private System.Windows.Forms.Button btnTwos;
        private System.Windows.Forms.Button btnThrees;
        private System.Windows.Forms.Button btnFours;
        private System.Windows.Forms.Button btnFives;
        private System.Windows.Forms.Button btnSixes;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnBonus;
        private System.Windows.Forms.Button btn3ofKind;
        private System.Windows.Forms.Button btn4ofKind;
        private System.Windows.Forms.Button btnFullH;
        private System.Windows.Forms.Button btnSmallS;
        private System.Windows.Forms.Button btnLargeS;
        private System.Windows.Forms.Button btnChance;
        private System.Windows.Forms.Button btnYAHTZEE;
        private System.Windows.Forms.Label lbl_3ofkindScoreP1;
        private System.Windows.Forms.Label lbl_bonusP1;
        private System.Windows.Forms.Label lbl_totalP1;
        private Dices dices5;
        private Dices dices4;
        private Dices dices3;
        private Dices dices2;
        private Dices dices1;
    }
}

