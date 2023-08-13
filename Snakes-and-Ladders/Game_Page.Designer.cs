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
            this.GameBoard = new System.Windows.Forms.PictureBox();
            this.Dice_Panel = new System.Windows.Forms.Panel();
            this.btn_Rolling = new System.Windows.Forms.Button();
            this.lbl_Player_Turn = new System.Windows.Forms.Label();
            this.Buttons_Panel = new System.Windows.Forms.Panel();
            this.New = new System.Windows.Forms.Button();
            this.Summary = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Player1Name = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.Player3Name = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.Points_Panel = new System.Windows.Forms.Panel();
            this.Player5_Square = new System.Windows.Forms.Button();
            this.Player4_Square = new System.Windows.Forms.Button();
            this.Player3_Square = new System.Windows.Forms.Button();
            this.Player2_Square = new System.Windows.Forms.Button();
            this.Player1_Square = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Player5_Mark = new System.Windows.Forms.PictureBox();
            this.Player4_Mark = new System.Windows.Forms.PictureBox();
            this.Player5Name = new System.Windows.Forms.Label();
            this.Player4Name = new System.Windows.Forms.Label();
            this.Player3_Mark = new System.Windows.Forms.PictureBox();
            this.Player2_Mark = new System.Windows.Forms.PictureBox();
            this.Player1_Mark = new System.Windows.Forms.PictureBox();
            this.Dice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).BeginInit();
            this.Dice_Panel.SuspendLayout();
            this.Buttons_Panel.SuspendLayout();
            this.Points_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player5_Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4_Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3_Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2_Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1_Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).BeginInit();
            this.SuspendLayout();
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
            this.Buttons_Panel.Location = new System.Drawing.Point(1038, 689);
            this.Buttons_Panel.Name = "Buttons_Panel";
            this.Buttons_Panel.Size = new System.Drawing.Size(742, 246);
            this.Buttons_Panel.TabIndex = 5;
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.LimeGreen;
            this.New.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.Color.White;
            this.New.Location = new System.Drawing.Point(242, 21);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(250, 92);
            this.New.TabIndex = 34;
            this.New.Text = "New Game";
            this.New.UseVisualStyleBackColor = false;
            // 
            // Summary
            // 
            this.Summary.BackColor = System.Drawing.Color.LimeGreen;
            this.Summary.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summary.ForeColor = System.Drawing.Color.White;
            this.Summary.Location = new System.Drawing.Point(20, 140);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(250, 92);
            this.Summary.TabIndex = 32;
            this.Summary.Text = "Game Summary";
            this.Summary.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.LimeGreen;
            this.Close.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(471, 140);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(250, 92);
            this.Close.TabIndex = 31;
            this.Close.Text = "Close Game";
            this.Close.UseVisualStyleBackColor = false;
            // 
            // Player1Name
            // 
            this.Player1Name.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Name.ForeColor = System.Drawing.Color.White;
            this.Player1Name.Location = new System.Drawing.Point(26, 36);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(212, 50);
            this.Player1Name.TabIndex = 25;
            this.Player1Name.Text = "Player1";
            // 
            // Player2Name
            // 
            this.Player2Name.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Name.ForeColor = System.Drawing.Color.White;
            this.Player2Name.Location = new System.Drawing.Point(26, 119);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(212, 50);
            this.Player2Name.TabIndex = 26;
            this.Player2Name.Text = "Player2";
            // 
            // Player3Name
            // 
            this.Player3Name.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3Name.ForeColor = System.Drawing.Color.White;
            this.Player3Name.Location = new System.Drawing.Point(26, 202);
            this.Player3Name.Name = "Player3Name";
            this.Player3Name.Size = new System.Drawing.Size(212, 50);
            this.Player3Name.TabIndex = 27;
            this.Player3Name.Text = "Player3";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(337, 36);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(256, 50);
            this.lbl1.TabIndex = 28;
            this.lbl1.Text = "Square Number";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(337, 119);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(256, 50);
            this.lbl2.TabIndex = 29;
            this.lbl2.Text = "Square Number";
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(337, 202);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(256, 50);
            this.lbl3.TabIndex = 30;
            this.lbl3.Text = "Square Number";
            // 
            // Points_Panel
            // 
            this.Points_Panel.Controls.Add(this.Player5_Square);
            this.Points_Panel.Controls.Add(this.Player4_Square);
            this.Points_Panel.Controls.Add(this.Player3_Square);
            this.Points_Panel.Controls.Add(this.Player2_Square);
            this.Points_Panel.Controls.Add(this.Player1_Square);
            this.Points_Panel.Controls.Add(this.lbl5);
            this.Points_Panel.Controls.Add(this.lbl4);
            this.Points_Panel.Controls.Add(this.Player5_Mark);
            this.Points_Panel.Controls.Add(this.Player4_Mark);
            this.Points_Panel.Controls.Add(this.Player5Name);
            this.Points_Panel.Controls.Add(this.Player4Name);
            this.Points_Panel.Controls.Add(this.Player3_Mark);
            this.Points_Panel.Controls.Add(this.Player2_Mark);
            this.Points_Panel.Controls.Add(this.Player1_Mark);
            this.Points_Panel.Controls.Add(this.lbl3);
            this.Points_Panel.Controls.Add(this.lbl2);
            this.Points_Panel.Controls.Add(this.lbl1);
            this.Points_Panel.Controls.Add(this.Player3Name);
            this.Points_Panel.Controls.Add(this.Player2Name);
            this.Points_Panel.Controls.Add(this.Player1Name);
            this.Points_Panel.Location = new System.Drawing.Point(1038, 203);
            this.Points_Panel.Name = "Points_Panel";
            this.Points_Panel.Size = new System.Drawing.Size(742, 470);
            this.Points_Panel.TabIndex = 3;
            // 
            // Player5_Square
            // 
            this.Player5_Square.BackColor = System.Drawing.Color.LimeGreen;
            this.Player5_Square.Enabled = false;
            this.Player5_Square.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player5_Square.Location = new System.Drawing.Point(616, 381);
            this.Player5_Square.Name = "Player5_Square";
            this.Player5_Square.Size = new System.Drawing.Size(61, 50);
            this.Player5_Square.TabIndex = 73;
            this.Player5_Square.Text = "0";
            this.Player5_Square.UseVisualStyleBackColor = false;
            // 
            // Player4_Square
            // 
            this.Player4_Square.BackColor = System.Drawing.Color.LimeGreen;
            this.Player4_Square.Enabled = false;
            this.Player4_Square.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4_Square.Location = new System.Drawing.Point(616, 291);
            this.Player4_Square.Name = "Player4_Square";
            this.Player4_Square.Size = new System.Drawing.Size(61, 50);
            this.Player4_Square.TabIndex = 72;
            this.Player4_Square.Text = "0";
            this.Player4_Square.UseVisualStyleBackColor = false;
            // 
            // Player3_Square
            // 
            this.Player3_Square.BackColor = System.Drawing.Color.LimeGreen;
            this.Player3_Square.Enabled = false;
            this.Player3_Square.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3_Square.Location = new System.Drawing.Point(616, 202);
            this.Player3_Square.Name = "Player3_Square";
            this.Player3_Square.Size = new System.Drawing.Size(61, 50);
            this.Player3_Square.TabIndex = 71;
            this.Player3_Square.Text = "0";
            this.Player3_Square.UseVisualStyleBackColor = false;
            // 
            // Player2_Square
            // 
            this.Player2_Square.BackColor = System.Drawing.Color.LimeGreen;
            this.Player2_Square.Enabled = false;
            this.Player2_Square.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2_Square.Location = new System.Drawing.Point(616, 119);
            this.Player2_Square.Name = "Player2_Square";
            this.Player2_Square.Size = new System.Drawing.Size(61, 50);
            this.Player2_Square.TabIndex = 70;
            this.Player2_Square.Text = "0";
            this.Player2_Square.UseVisualStyleBackColor = false;
            // 
            // Player1_Square
            // 
            this.Player1_Square.BackColor = System.Drawing.Color.LimeGreen;
            this.Player1_Square.Enabled = false;
            this.Player1_Square.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1_Square.Location = new System.Drawing.Point(616, 36);
            this.Player1_Square.Name = "Player1_Square";
            this.Player1_Square.Size = new System.Drawing.Size(61, 50);
            this.Player1_Square.TabIndex = 69;
            this.Player1_Square.Text = "0";
            this.Player1_Square.UseVisualStyleBackColor = false;
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(337, 381);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(256, 50);
            this.lbl5.TabIndex = 68;
            this.lbl5.Text = "Square Number";
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(337, 291);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(256, 50);
            this.lbl4.TabIndex = 67;
            this.lbl4.Text = "Square Number";
            // 
            // Player5_Mark
            // 
            this.Player5_Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player5_Mark.Location = new System.Drawing.Point(244, 381);
            this.Player5_Mark.Name = "Player5_Mark";
            this.Player5_Mark.Size = new System.Drawing.Size(61, 50);
            this.Player5_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player5_Mark.TabIndex = 66;
            this.Player5_Mark.TabStop = false;
            // 
            // Player4_Mark
            // 
            this.Player4_Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player4_Mark.Location = new System.Drawing.Point(244, 291);
            this.Player4_Mark.Name = "Player4_Mark";
            this.Player4_Mark.Size = new System.Drawing.Size(61, 50);
            this.Player4_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player4_Mark.TabIndex = 65;
            this.Player4_Mark.TabStop = false;
            // 
            // Player5Name
            // 
            this.Player5Name.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player5Name.ForeColor = System.Drawing.Color.White;
            this.Player5Name.Location = new System.Drawing.Point(26, 381);
            this.Player5Name.Name = "Player5Name";
            this.Player5Name.Size = new System.Drawing.Size(212, 50);
            this.Player5Name.TabIndex = 64;
            this.Player5Name.Text = "Player5";
            // 
            // Player4Name
            // 
            this.Player4Name.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4Name.ForeColor = System.Drawing.Color.White;
            this.Player4Name.Location = new System.Drawing.Point(26, 291);
            this.Player4Name.Name = "Player4Name";
            this.Player4Name.Size = new System.Drawing.Size(212, 50);
            this.Player4Name.TabIndex = 63;
            this.Player4Name.Text = "Player4";
            // 
            // Player3_Mark
            // 
            this.Player3_Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player3_Mark.Location = new System.Drawing.Point(244, 202);
            this.Player3_Mark.Name = "Player3_Mark";
            this.Player3_Mark.Size = new System.Drawing.Size(61, 50);
            this.Player3_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player3_Mark.TabIndex = 62;
            this.Player3_Mark.TabStop = false;
            // 
            // Player2_Mark
            // 
            this.Player2_Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player2_Mark.Location = new System.Drawing.Point(244, 119);
            this.Player2_Mark.Name = "Player2_Mark";
            this.Player2_Mark.Size = new System.Drawing.Size(61, 50);
            this.Player2_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2_Mark.TabIndex = 61;
            this.Player2_Mark.TabStop = false;
            // 
            // Player1_Mark
            // 
            this.Player1_Mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1_Mark.Location = new System.Drawing.Point(244, 36);
            this.Player1_Mark.Name = "Player1_Mark";
            this.Player1_Mark.Size = new System.Drawing.Size(61, 50);
            this.Player1_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1_Mark.TabIndex = 60;
            this.Player1_Mark.TabStop = false;
            // 
            // Dice
            // 
            this.Dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dice.Location = new System.Drawing.Point(74, 33);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(106, 85);
            this.Dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice.TabIndex = 74;
            this.Dice.TabStop = false;
            // 
            // Game_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1832, 973);
            this.Controls.Add(this.Buttons_Panel);
            this.Controls.Add(this.Dice_Panel);
            this.Controls.Add(this.Points_Panel);
            this.Controls.Add(this.GameBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1850, 1020);
            this.Name = "Game_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_Page_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).EndInit();
            this.Dice_Panel.ResumeLayout(false);
            this.Buttons_Panel.ResumeLayout(false);
            this.Points_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player5_Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4_Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3_Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2_Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1_Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox GameBoard;
        private System.Windows.Forms.Panel Dice_Panel;
        private System.Windows.Forms.Panel Buttons_Panel;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Summary;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.Label Player2Name;
        private System.Windows.Forms.Label Player3Name;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl_Player_Turn;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel Points_Panel;
        private System.Windows.Forms.Label Player5Name;
        private System.Windows.Forms.Label Player4Name;
        private System.Windows.Forms.PictureBox Player3_Mark;
        private System.Windows.Forms.PictureBox Player2_Mark;
        private System.Windows.Forms.PictureBox Player1_Mark;
        private System.Windows.Forms.PictureBox Player5_Mark;
        private System.Windows.Forms.PictureBox Player4_Mark;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button Player5_Square;
        private System.Windows.Forms.Button Player4_Square;
        private System.Windows.Forms.Button Player3_Square;
        private System.Windows.Forms.Button Player2_Square;
        private System.Windows.Forms.Button Player1_Square;
        private System.Windows.Forms.Button btn_Rolling;
        private System.Windows.Forms.PictureBox Dice;
    }
}