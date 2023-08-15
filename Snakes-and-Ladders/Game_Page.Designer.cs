namespace Snakes_and_Ladders
{
    partial class Game_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Page));
            this.Dice_Panel = new System.Windows.Forms.Panel();
            this.Dice = new System.Windows.Forms.PictureBox();
            this.btn_Rolling = new System.Windows.Forms.Button();
            this.lbl_Player_Turn = new System.Windows.Forms.Label();
            this.Buttons_Panel = new System.Windows.Forms.Panel();
            this.New = new System.Windows.Forms.Button();
            this.Summary = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Squares_Panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Player5_Panel = new System.Windows.Forms.Panel();
            this.Player5_Square_After = new System.Windows.Forms.Button();
            this.Player5_Square_Before = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.Player5_Mark = new System.Windows.Forms.PictureBox();
            this.Player5_Name = new System.Windows.Forms.Label();
            this.Player4_Panel = new System.Windows.Forms.Panel();
            this.Player4_Square_After = new System.Windows.Forms.Button();
            this.Player4_Square_Before = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Player4_Mark = new System.Windows.Forms.PictureBox();
            this.Player4_Name = new System.Windows.Forms.Label();
            this.Player3_Panel = new System.Windows.Forms.Panel();
            this.Player3_Square_After = new System.Windows.Forms.Button();
            this.Player3_Square_Before = new System.Windows.Forms.Button();
            this.Player3_Mark = new System.Windows.Forms.PictureBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.Player3_Name = new System.Windows.Forms.Label();
            this.Player2_Panel = new System.Windows.Forms.Panel();
            this.Player2_Square_After = new System.Windows.Forms.Button();
            this.Player2_Square_Before = new System.Windows.Forms.Button();
            this.Player2_Mark = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Player2_Name = new System.Windows.Forms.Label();
            this.Player1_Panel = new System.Windows.Forms.Panel();
            this.Player1_Square_After = new System.Windows.Forms.Button();
            this.Player1_Square_Before = new System.Windows.Forms.Button();
            this.Player1_Mark = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.Player1_Name = new System.Windows.Forms.Label();
            this.GameBoard = new System.Windows.Forms.PictureBox();
            this.Dice_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).BeginInit();
            this.Buttons_Panel.SuspendLayout();
            this.Squares_Panel.SuspendLayout();
            this.Player5_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player5_Mark)).BeginInit();
            this.Player4_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player4_Mark)).BeginInit();
            this.Player3_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player3_Mark)).BeginInit();
            this.Player2_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2_Mark)).BeginInit();
            this.Player1_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1_Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // Dice_Panel
            // 
            this.Dice_Panel.Controls.Add(this.Dice);
            this.Dice_Panel.Controls.Add(this.btn_Rolling);
            this.Dice_Panel.Controls.Add(this.lbl_Player_Turn);
            this.Dice_Panel.Location = new System.Drawing.Point(1038, 45);
            this.Dice_Panel.Name = "Dice_Panel";
            this.Dice_Panel.Size = new System.Drawing.Size(742, 152);
            this.Dice_Panel.TabIndex = 4;
            // 
            // Dice
            // 
            this.Dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dice.Image = global::Snakes_and_Ladders.Properties.Resources.Rolling_Dice;
            this.Dice.Location = new System.Drawing.Point(74, 33);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(106, 85);
            this.Dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice.TabIndex = 74;
            this.Dice.TabStop = false;
            // 
            // btn_Rolling
            // 
            this.btn_Rolling.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Rolling.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rolling.ForeColor = System.Drawing.Color.White;
            this.btn_Rolling.Location = new System.Drawing.Point(270, 42);
            this.btn_Rolling.Name = "btn_Rolling";
            this.btn_Rolling.Size = new System.Drawing.Size(207, 66);
            this.btn_Rolling.TabIndex = 35;
            this.btn_Rolling.Text = "Roll The Dice";
            this.btn_Rolling.UseVisualStyleBackColor = false;
            this.btn_Rolling.Click += new System.EventHandler(this.btn_Rolling_Click);
            // 
            // lbl_Player_Turn
            // 
            this.lbl_Player_Turn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player_Turn.ForeColor = System.Drawing.Color.White;
            this.lbl_Player_Turn.Location = new System.Drawing.Point(491, 51);
            this.lbl_Player_Turn.Name = "lbl_Player_Turn";
            this.lbl_Player_Turn.Size = new System.Drawing.Size(230, 53);
            this.lbl_Player_Turn.TabIndex = 32;
            this.lbl_Player_Turn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Buttons_Panel
            // 
            this.Buttons_Panel.Controls.Add(this.New);
            this.Buttons_Panel.Controls.Add(this.Summary);
            this.Buttons_Panel.Controls.Add(this.Close);
            this.Buttons_Panel.Location = new System.Drawing.Point(1038, 706);
            this.Buttons_Panel.Name = "Buttons_Panel";
            this.Buttons_Panel.Size = new System.Drawing.Size(742, 229);
            this.Buttons_Panel.TabIndex = 5;
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.LimeGreen;
            this.New.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.Color.White;
            this.New.Location = new System.Drawing.Point(260, 41);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(230, 80);
            this.New.TabIndex = 34;
            this.New.Text = "New Game";
            this.New.UseVisualStyleBackColor = false;
            this.New.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.New.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // Summary
            // 
            this.Summary.BackColor = System.Drawing.Color.LimeGreen;
            this.Summary.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summary.ForeColor = System.Drawing.Color.White;
            this.Summary.Location = new System.Drawing.Point(20, 140);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(230, 80);
            this.Summary.TabIndex = 32;
            this.Summary.Text = "Game Summary";
            this.Summary.UseVisualStyleBackColor = false;
            this.Summary.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.Summary.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.LimeGreen;
            this.Close.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(496, 140);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(230, 80);
            this.Close.TabIndex = 31;
            this.Close.Text = "Close Game";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // Squares_Panel
            // 
            this.Squares_Panel.Controls.Add(this.label2);
            this.Squares_Panel.Controls.Add(this.label1);
            this.Squares_Panel.Controls.Add(this.Player5_Panel);
            this.Squares_Panel.Controls.Add(this.Player4_Panel);
            this.Squares_Panel.Controls.Add(this.Player3_Panel);
            this.Squares_Panel.Controls.Add(this.Player2_Panel);
            this.Squares_Panel.Controls.Add(this.Player1_Panel);
            this.Squares_Panel.Location = new System.Drawing.Point(1038, 203);
            this.Squares_Panel.Name = "Squares_Panel";
            this.Squares_Panel.Size = new System.Drawing.Size(742, 497);
            this.Squares_Panel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(669, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 42);
            this.label2.TabIndex = 76;
            this.label2.Text = "Now";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(585, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 35);
            this.label1.TabIndex = 75;
            this.label1.Text = "Before";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player5_Panel
            // 
            this.Player5_Panel.Controls.Add(this.Player5_Square_After);
            this.Player5_Panel.Controls.Add(this.Player5_Square_Before);
            this.Player5_Panel.Controls.Add(this.lbl5);
            this.Player5_Panel.Controls.Add(this.Player5_Mark);
            this.Player5_Panel.Controls.Add(this.Player5_Name);
            this.Player5_Panel.Location = new System.Drawing.Point(3, 415);
            this.Player5_Panel.Name = "Player5_Panel";
            this.Player5_Panel.Size = new System.Drawing.Size(735, 70);
            this.Player5_Panel.TabIndex = 6;
            // 
            // Player5_Square_After
            // 
            this.Player5_Square_After.BackColor = System.Drawing.Color.LimeGreen;
            this.Player5_Square_After.Enabled = false;
            this.Player5_Square_After.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player5_Square_After.Location = new System.Drawing.Point(671, 10);
            this.Player5_Square_After.Name = "Player5_Square_After";
            this.Player5_Square_After.Size = new System.Drawing.Size(61, 50);
            this.Player5_Square_After.TabIndex = 78;
            this.Player5_Square_After.UseVisualStyleBackColor = false;
            // 
            // Player5_Square_Before
            // 
            this.Player5_Square_Before.BackColor = System.Drawing.Color.LimeGreen;
            this.Player5_Square_Before.Enabled = false;
            this.Player5_Square_Before.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player5_Square_Before.Location = new System.Drawing.Point(586, 10);
            this.Player5_Square_Before.Name = "Player5_Square_Before";
            this.Player5_Square_Before.Size = new System.Drawing.Size(61, 50);
            this.Player5_Square_Before.TabIndex = 77;
            this.Player5_Square_Before.UseVisualStyleBackColor = false;
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(324, 10);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(256, 50);
            this.lbl5.TabIndex = 76;
            this.lbl5.Text = "Square Number";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player5_Mark
            // 
            this.Player5_Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player5_Mark.Location = new System.Drawing.Point(241, 10);
            this.Player5_Mark.Name = "Player5_Mark";
            this.Player5_Mark.Size = new System.Drawing.Size(61, 50);
            this.Player5_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player5_Mark.TabIndex = 75;
            this.Player5_Mark.TabStop = false;
            // 
            // Player5_Name
            // 
            this.Player5_Name.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player5_Name.ForeColor = System.Drawing.Color.White;
            this.Player5_Name.Location = new System.Drawing.Point(23, 10);
            this.Player5_Name.Name = "Player5_Name";
            this.Player5_Name.Size = new System.Drawing.Size(212, 50);
            this.Player5_Name.TabIndex = 74;
            this.Player5_Name.Text = "Player5";
            this.Player5_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Player4_Panel
            // 
            this.Player4_Panel.Controls.Add(this.Player4_Square_After);
            this.Player4_Panel.Controls.Add(this.Player4_Square_Before);
            this.Player4_Panel.Controls.Add(this.lbl4);
            this.Player4_Panel.Controls.Add(this.Player4_Mark);
            this.Player4_Panel.Controls.Add(this.Player4_Name);
            this.Player4_Panel.Location = new System.Drawing.Point(3, 323);
            this.Player4_Panel.Name = "Player4_Panel";
            this.Player4_Panel.Size = new System.Drawing.Size(735, 70);
            this.Player4_Panel.TabIndex = 6;
            // 
            // Player4_Square_After
            // 
            this.Player4_Square_After.BackColor = System.Drawing.Color.LimeGreen;
            this.Player4_Square_After.Enabled = false;
            this.Player4_Square_After.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4_Square_After.Location = new System.Drawing.Point(671, 10);
            this.Player4_Square_After.Name = "Player4_Square_After";
            this.Player4_Square_After.Size = new System.Drawing.Size(61, 50);
            this.Player4_Square_After.TabIndex = 77;
            this.Player4_Square_After.UseVisualStyleBackColor = false;
            // 
            // Player4_Square_Before
            // 
            this.Player4_Square_Before.BackColor = System.Drawing.Color.LimeGreen;
            this.Player4_Square_Before.Enabled = false;
            this.Player4_Square_Before.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4_Square_Before.Location = new System.Drawing.Point(586, 10);
            this.Player4_Square_Before.Name = "Player4_Square_Before";
            this.Player4_Square_Before.Size = new System.Drawing.Size(61, 50);
            this.Player4_Square_Before.TabIndex = 76;
            this.Player4_Square_Before.UseVisualStyleBackColor = false;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(324, 10);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(256, 50);
            this.lbl4.TabIndex = 75;
            this.lbl4.Text = "Square Number";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player4_Mark
            // 
            this.Player4_Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player4_Mark.Location = new System.Drawing.Point(241, 10);
            this.Player4_Mark.Name = "Player4_Mark";
            this.Player4_Mark.Size = new System.Drawing.Size(61, 50);
            this.Player4_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player4_Mark.TabIndex = 74;
            this.Player4_Mark.TabStop = false;
            // 
            // Player4_Name
            // 
            this.Player4_Name.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4_Name.ForeColor = System.Drawing.Color.White;
            this.Player4_Name.Location = new System.Drawing.Point(23, 10);
            this.Player4_Name.Name = "Player4_Name";
            this.Player4_Name.Size = new System.Drawing.Size(212, 50);
            this.Player4_Name.TabIndex = 73;
            this.Player4_Name.Text = "Player4";
            this.Player4_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Player3_Panel
            // 
            this.Player3_Panel.Controls.Add(this.Player3_Square_After);
            this.Player3_Panel.Controls.Add(this.Player3_Square_Before);
            this.Player3_Panel.Controls.Add(this.Player3_Mark);
            this.Player3_Panel.Controls.Add(this.lbl3);
            this.Player3_Panel.Controls.Add(this.Player3_Name);
            this.Player3_Panel.Location = new System.Drawing.Point(3, 231);
            this.Player3_Panel.Name = "Player3_Panel";
            this.Player3_Panel.Size = new System.Drawing.Size(735, 70);
            this.Player3_Panel.TabIndex = 6;
            // 
            // Player3_Square_After
            // 
            this.Player3_Square_After.BackColor = System.Drawing.Color.LimeGreen;
            this.Player3_Square_After.Enabled = false;
            this.Player3_Square_After.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3_Square_After.Location = new System.Drawing.Point(671, 10);
            this.Player3_Square_After.Name = "Player3_Square_After";
            this.Player3_Square_After.Size = new System.Drawing.Size(61, 50);
            this.Player3_Square_After.TabIndex = 76;
            this.Player3_Square_After.UseVisualStyleBackColor = false;
            // 
            // Player3_Square_Before
            // 
            this.Player3_Square_Before.BackColor = System.Drawing.Color.LimeGreen;
            this.Player3_Square_Before.Enabled = false;
            this.Player3_Square_Before.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3_Square_Before.Location = new System.Drawing.Point(586, 10);
            this.Player3_Square_Before.Name = "Player3_Square_Before";
            this.Player3_Square_Before.Size = new System.Drawing.Size(61, 50);
            this.Player3_Square_Before.TabIndex = 75;
            this.Player3_Square_Before.UseVisualStyleBackColor = false;
            // 
            // Player3_Mark
            // 
            this.Player3_Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player3_Mark.Location = new System.Drawing.Point(241, 10);
            this.Player3_Mark.Name = "Player3_Mark";
            this.Player3_Mark.Size = new System.Drawing.Size(61, 50);
            this.Player3_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player3_Mark.TabIndex = 74;
            this.Player3_Mark.TabStop = false;
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(324, 10);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(256, 50);
            this.lbl3.TabIndex = 73;
            this.lbl3.Text = "Square Number";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player3_Name
            // 
            this.Player3_Name.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3_Name.ForeColor = System.Drawing.Color.White;
            this.Player3_Name.Location = new System.Drawing.Point(23, 10);
            this.Player3_Name.Name = "Player3_Name";
            this.Player3_Name.Size = new System.Drawing.Size(212, 50);
            this.Player3_Name.TabIndex = 72;
            this.Player3_Name.Text = "Player3";
            this.Player3_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Player2_Panel
            // 
            this.Player2_Panel.Controls.Add(this.Player2_Square_After);
            this.Player2_Panel.Controls.Add(this.Player2_Square_Before);
            this.Player2_Panel.Controls.Add(this.Player2_Mark);
            this.Player2_Panel.Controls.Add(this.lbl2);
            this.Player2_Panel.Controls.Add(this.Player2_Name);
            this.Player2_Panel.Location = new System.Drawing.Point(3, 142);
            this.Player2_Panel.Name = "Player2_Panel";
            this.Player2_Panel.Size = new System.Drawing.Size(735, 70);
            this.Player2_Panel.TabIndex = 6;
            // 
            // Player2_Square_After
            // 
            this.Player2_Square_After.BackColor = System.Drawing.Color.LimeGreen;
            this.Player2_Square_After.Enabled = false;
            this.Player2_Square_After.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2_Square_After.Location = new System.Drawing.Point(671, 10);
            this.Player2_Square_After.Name = "Player2_Square_After";
            this.Player2_Square_After.Size = new System.Drawing.Size(61, 50);
            this.Player2_Square_After.TabIndex = 75;
            this.Player2_Square_After.UseVisualStyleBackColor = false;
            // 
            // Player2_Square_Before
            // 
            this.Player2_Square_Before.BackColor = System.Drawing.Color.LimeGreen;
            this.Player2_Square_Before.Enabled = false;
            this.Player2_Square_Before.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2_Square_Before.Location = new System.Drawing.Point(586, 10);
            this.Player2_Square_Before.Name = "Player2_Square_Before";
            this.Player2_Square_Before.Size = new System.Drawing.Size(61, 50);
            this.Player2_Square_Before.TabIndex = 74;
            this.Player2_Square_Before.UseVisualStyleBackColor = false;
            // 
            // Player2_Mark
            // 
            this.Player2_Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player2_Mark.Location = new System.Drawing.Point(241, 10);
            this.Player2_Mark.Name = "Player2_Mark";
            this.Player2_Mark.Size = new System.Drawing.Size(61, 50);
            this.Player2_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2_Mark.TabIndex = 73;
            this.Player2_Mark.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(324, 10);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(256, 50);
            this.lbl2.TabIndex = 72;
            this.lbl2.Text = "Square Number";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2_Name
            // 
            this.Player2_Name.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2_Name.ForeColor = System.Drawing.Color.White;
            this.Player2_Name.Location = new System.Drawing.Point(23, 10);
            this.Player2_Name.Name = "Player2_Name";
            this.Player2_Name.Size = new System.Drawing.Size(212, 50);
            this.Player2_Name.TabIndex = 71;
            this.Player2_Name.Text = "Player2";
            this.Player2_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Player1_Panel
            // 
            this.Player1_Panel.Controls.Add(this.Player1_Square_After);
            this.Player1_Panel.Controls.Add(this.Player1_Square_Before);
            this.Player1_Panel.Controls.Add(this.Player1_Mark);
            this.Player1_Panel.Controls.Add(this.lbl1);
            this.Player1_Panel.Controls.Add(this.Player1_Name);
            this.Player1_Panel.Location = new System.Drawing.Point(3, 50);
            this.Player1_Panel.Name = "Player1_Panel";
            this.Player1_Panel.Size = new System.Drawing.Size(736, 70);
            this.Player1_Panel.TabIndex = 6;
            // 
            // Player1_Square_After
            // 
            this.Player1_Square_After.BackColor = System.Drawing.Color.LimeGreen;
            this.Player1_Square_After.Enabled = false;
            this.Player1_Square_After.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1_Square_After.Location = new System.Drawing.Point(672, 11);
            this.Player1_Square_After.Name = "Player1_Square_After";
            this.Player1_Square_After.Size = new System.Drawing.Size(61, 50);
            this.Player1_Square_After.TabIndex = 74;
            this.Player1_Square_After.UseVisualStyleBackColor = false;
            // 
            // Player1_Square_Before
            // 
            this.Player1_Square_Before.BackColor = System.Drawing.Color.LimeGreen;
            this.Player1_Square_Before.Enabled = false;
            this.Player1_Square_Before.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1_Square_Before.Location = new System.Drawing.Point(586, 11);
            this.Player1_Square_Before.Name = "Player1_Square_Before";
            this.Player1_Square_Before.Size = new System.Drawing.Size(61, 50);
            this.Player1_Square_Before.TabIndex = 73;
            this.Player1_Square_Before.UseVisualStyleBackColor = false;
            // 
            // Player1_Mark
            // 
            this.Player1_Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1_Mark.Location = new System.Drawing.Point(241, 11);
            this.Player1_Mark.Name = "Player1_Mark";
            this.Player1_Mark.Size = new System.Drawing.Size(61, 50);
            this.Player1_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1_Mark.TabIndex = 72;
            this.Player1_Mark.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(324, 11);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(256, 50);
            this.lbl1.TabIndex = 71;
            this.lbl1.Text = "Square Number";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1_Name
            // 
            this.Player1_Name.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1_Name.ForeColor = System.Drawing.Color.White;
            this.Player1_Name.Location = new System.Drawing.Point(23, 11);
            this.Player1_Name.Name = "Player1_Name";
            this.Player1_Name.Size = new System.Drawing.Size(212, 50);
            this.Player1_Name.TabIndex = 70;
            this.Player1_Name.Text = "Player1";
            this.Player1_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameBoard
            // 
            this.GameBoard.Image = global::Snakes_and_Ladders.Properties.Resources.Snake_and_Ladders_Game_Board;
            this.GameBoard.Location = new System.Drawing.Point(40, 45);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(971, 890);
            this.GameBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameBoard.TabIndex = 2;
            this.GameBoard.TabStop = false;
            // 
            // Game_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1832, 973);
            this.Controls.Add(this.Buttons_Panel);
            this.Controls.Add(this.Dice_Panel);
            this.Controls.Add(this.Squares_Panel);
            this.Controls.Add(this.GameBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1850, 1020);
            this.Name = "Game_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_Page_FormClosing);
            this.Load += new System.EventHandler(this.Game_Page_Load);
            this.Dice_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).EndInit();
            this.Buttons_Panel.ResumeLayout(false);
            this.Squares_Panel.ResumeLayout(false);
            this.Player5_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player5_Mark)).EndInit();
            this.Player4_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player4_Mark)).EndInit();
            this.Player3_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player3_Mark)).EndInit();
            this.Player2_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player2_Mark)).EndInit();
            this.Player1_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player1_Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox GameBoard;
        private System.Windows.Forms.Panel Dice_Panel;
        private System.Windows.Forms.Panel Buttons_Panel;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Summary;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label lbl_Player_Turn;
        private System.Windows.Forms.Panel Squares_Panel;
        private System.Windows.Forms.Button btn_Rolling;
        private System.Windows.Forms.PictureBox Dice;
        private System.Windows.Forms.Panel Player1_Panel;
        private System.Windows.Forms.Button Player1_Square_Before;
        private System.Windows.Forms.PictureBox Player1_Mark;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label Player1_Name;
        private System.Windows.Forms.Panel Player2_Panel;
        private System.Windows.Forms.Panel Player5_Panel;
        private System.Windows.Forms.Button Player5_Square_Before;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.PictureBox Player5_Mark;
        private System.Windows.Forms.Label Player5_Name;
        private System.Windows.Forms.Panel Player4_Panel;
        private System.Windows.Forms.Button Player4_Square_Before;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.PictureBox Player4_Mark;
        private System.Windows.Forms.Label Player4_Name;
        private System.Windows.Forms.Panel Player3_Panel;
        private System.Windows.Forms.Button Player3_Square_Before;
        private System.Windows.Forms.PictureBox Player3_Mark;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label Player3_Name;
        private System.Windows.Forms.Button Player2_Square_Before;
        private System.Windows.Forms.PictureBox Player2_Mark;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label Player2_Name;
        private System.Windows.Forms.Button Player5_Square_After;
        private System.Windows.Forms.Button Player4_Square_After;
        private System.Windows.Forms.Button Player3_Square_After;
        private System.Windows.Forms.Button Player2_Square_After;
        private System.Windows.Forms.Button Player1_Square_After;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}