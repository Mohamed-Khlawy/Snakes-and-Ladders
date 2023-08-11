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
        //Define 4 Lists for Marks ComboBoxes and PictureBoxes, Also PlayerNames Labels and TextBoxes
        private List<ComboBox> comboBoxList;
        private List<PictureBox> pictureBoxList;
        private List<Label> playerNamesList;
        private List<TextBox> playerNamesTxt_List;

        // Intialize numberOfPlayers with 2 players at least
        int numberOfPlayers = 2;
        public Welcome_Page()
        {
            InitializeComponent();

            // Make the Results_ Panel and NamesAndMarks_Panel invisible untill choosing nuberOfPlayers
            Results_Panel.Visible = false;
            NamesAndMarks_Panel.Visible = false;

            // Initialize the 4 Lists defined above
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
            playerNamesList = new List<Label>
            {
                Player1_Name,
                Player2_Name,
                Player3_Name,
                Player4_Name,
                Player5_Name
            };
            playerNamesTxt_List = new List<TextBox>
            {
                txt_Player1,
                txt_Player2,
                txt_Player3,
                txt_Player4,
                txt_Player5
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Rd_btnPlayers_Click(object sender, EventArgs e)
        {
            // Reset the marks to avoid any wrongs and remark it with new choises
            ResetPlayerMarks_ComboBoxes();
            Results_Panel.Visible = false;

            // Check which radioButton was checked to know numberOfPlayers
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

            // Review the NamesAndMarks_Panel to choose names and marks
            NamesAndMarks_Panel.Visible = true;
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if 2 comboBoxes has choosed the same value, and avoid this error
            ComboBox comboBox = (ComboBox)sender;
            foreach (ComboBox c in comboBoxList)
            {
                if (c != comboBox && c.SelectedIndex == comboBox.SelectedIndex && c.SelectedIndex != -1)
                {
                    MessageBox.Show("This color mark had been choosen by another player",
                        "Snakes and Ladders Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox.SelectedIndex = -1;
                    // Make the results inVisible to make the user choose new mark
                    Results_Panel.Visible = false;
                }
            }
            for(int i = 0; i<numberOfPlayers; i++)
            {
                // Check if all players choose a mark or not to view the Results Panel or not
                if (comboBoxList[i].SelectedIndex == -1)
                {
                    return;
                }
            }

            // View the Results panel as all players choose marks
            DisplayResults();
            Results_Panel.Visible = true;
        }
        private void Txt_TextChanged(object sender, EventArgs e)
        {
            // Update PlayerName in ResultsPanel with every change in any player textBox
            DisplayPlayerNames();
        }
        private void ResetPlayerMarks_ComboBoxes()
        {
            // Reset the player marks comboBoxes when user change numberOfPlayers
            foreach (ComboBox c in comboBoxList)
            {
                c.SelectedIndex = -1;
            }
        }
        private void DisplayResults()
        {
            // Display playerPanels with specific numberOfPlayers
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
            DisplayPlayerNames();
        }
        private void DisplayPlayerMarks()
        {
            // Display player marks as pictureBoxes with images in Resources folder
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
        private void DisplayPlayerNames()
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                playerNamesList[i].Text = playerNamesTxt_List[i].Text;
                if (playerNamesList[i].Text == "")
                    playerNamesList[i].Text = $"Player{i + 1}";
            }
        }
    }
}
