using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Snakes_and_Ladders
{
    public partial class Welcome_Page : Form
    {
        private List<ComboBox> comboBoxList;
        private List<PictureBox> pictureBoxList;
        int numberOfPlayers = 2;
        public Welcome_Page()
        {
            InitializeComponent();
            // Make the Results_ Panel and NamesAndMarks_Panel invisible untill choosing nuberOfPlayers
            Results_Panel.Visible = false;
            NamesAndMarks_Panel.Visible = false;
            // Initialize the combo box list
            comboBoxList = new List<ComboBox>
            {
                Marks1,
                Marks2,
                Marks3,
                Marks4,
                Marks5
            };
            pictureBoxList = new List<PictureBox>
            {
                Player1_Mark,
                Player2_Mark,
                Player3_Mark,
                Player4_Mark,
                Player5_Mark
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Rd_btnPlayers_Click(object sender, EventArgs e)
        {
            ResetPlayerMarks_ComboBoxes();
            Results_Panel.Visible = false;

            RadioButton radioButton = (RadioButton)sender;
            if (radioButton == TwoPlayers)
            {
                Player1_Panel.Visible = true;
                Player2_Panel.Visible = true;
                Player3_Panel.Visible = false;
                Player4_Panel.Visible = false;
                Player5_Panel.Visible = false;
                numberOfPlayers = 2;
            }
            else if (radioButton == ThreePlayers)
            {
                Player1_Panel.Visible = true;
                Player2_Panel.Visible = true;
                Player3_Panel.Visible = true;
                Player4_Panel.Visible = false;
                Player5_Panel.Visible = false;
                numberOfPlayers = 3;
            }
            else if (radioButton == FourPlayers)
            {
                Player1_Panel.Visible = true;
                Player2_Panel.Visible = true;
                Player3_Panel.Visible = true;
                Player4_Panel.Visible = true;
                Player5_Panel.Visible = false;
                numberOfPlayers = 4;
            }
            else if (radioButton == FivePlayers)
            {
                Player1_Panel.Visible = true;
                Player2_Panel.Visible = true;
                Player3_Panel.Visible = true;
                Player4_Panel.Visible = true;
                Player5_Panel.Visible = true;
                numberOfPlayers = 5;
            }
            NamesAndMarks_Panel.Visible = true;
            DisplayResults();
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            foreach (ComboBox c in comboBoxList)
            {
                if (c != comboBox && c.SelectedIndex == comboBox.SelectedIndex && c.SelectedIndex != -1)
                {
                    MessageBox.Show("This color mark had been choosen by another player",
                        "Snakes and Ladders Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox.SelectedIndex = -1;
                    Results_Panel.Visible = false;
                }
            }
            for(int i = 0; i<numberOfPlayers; i++)
            {
                if (comboBoxList[i].SelectedIndex == -1)
                {
                    return;
                }
            }
            DisplayResults();
            Results_Panel.Visible = true;
        }
        private void ResetPlayerMarks_ComboBoxes()
        {
            foreach (ComboBox c in comboBoxList)
            {
                c.SelectedIndex = -1;
            }
        }
        private void DisplayResults()
        {
            if (numberOfPlayers == 2)
            {
                Player1_Results.Visible = true;
                Player2_Results.Visible = true;
                Player3_Results.Visible = false;
                Player4_Results.Visible = false;
                Player5_Results.Visible = false;
            }
            else if (numberOfPlayers == 3)
            {
                Player1_Results.Visible = true;
                Player2_Results.Visible = true;
                Player3_Results.Visible = true;
                Player4_Results.Visible = false;
                Player5_Results.Visible = false;
            }
            else if (numberOfPlayers == 4)
            {
                Player1_Results.Visible = true;
                Player2_Results.Visible = true;
                Player3_Results.Visible = true;
                Player4_Results.Visible = true;
                Player5_Results.Visible = false;
            }
            else if (numberOfPlayers == 5)
            {
                Player1_Results.Visible = true;
                Player2_Results.Visible = true;
                Player3_Results.Visible = true;
                Player4_Results.Visible = true;
                Player5_Results.Visible = true;
            }
            DisplayPlayerMarks();
        }
        private void DisplayPlayerMarks()
        {
            for(int i = 0; i < numberOfPlayers; i++)
            {
                switch(comboBoxList[i].SelectedIndex)
                {
                    case 0:
                        pictureBoxList[i].Image = Properties.Resources.Red;
                        break;
                    case 1:
                        pictureBoxList[i].Image = Properties.Resources.Green;
                        break;
                    case 2:
                        pictureBoxList[i].Image = Properties.Resources.Blue;
                        break;
                    case 3:
                        pictureBoxList[i].Image = Properties.Resources.Purple;
                        break;
                    case 4:
                        pictureBoxList[i].Image = Properties.Resources.Orange;
                        break;
                }
            }
        }
    }
}
