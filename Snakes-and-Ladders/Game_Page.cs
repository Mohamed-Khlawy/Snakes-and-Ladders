using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_and_Ladders
{
    public partial class Game_Page : Form
    {
        // Define 6 Lists for pictureBoxes, labels, buttons
        private List<PictureBox> pictureBoxList;
        private List<Label> playerNamesList;
        private List<PictureBox> playerMarks;
        private List<Label> playerNames;
        private List<Button> squaresButtons_Before;
        private List<Button> squaresButtons_After;

        // Define Array for squares of players
        int[] squaresOfPlayers;

        // Intialize numberOfPlayers with 2 players
        int numberOfPlayers = 2;
        public Game_Page(List<PictureBox> _playerMarks, List<Label> _playerNames, int _numberOfPlayers)
        {
            InitializeComponent();

            // Assign parametrs for our lists
            playerMarks = _playerMarks;
            playerNames = _playerNames;
            numberOfPlayers = _numberOfPlayers;

            // Initialize the 4 lists with our GUI components
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
            squaresButtons_Before = new List<Button>
            {
                Player1_Square_Before,
                Player2_Square_Before, 
                Player3_Square_Before, 
                Player4_Square_Before,
                Player5_Square_Before,
            };
            squaresButtons_After = new List<Button>
            {
                Player1_Square_After,
                Player2_Square_After,
                Player3_Square_After,
                Player4_Square_After,
                Player5_Square_After,
            };

            // Unenable the Summary button until we finish the game
            Summary.Enabled = false;
        }

        private void Game_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Game_Page_Load(object sender, EventArgs e)
        {
            // Call UpdateSquares_Panel to intialize our Squares_Panel
            UpdateSquares_Panel();
        }
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Green;
        }
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.LimeGreen;
        }
        private void UpdateSquares_Panel()
        {
            // Intialize and assign the array with the numberOfPlayers and their intial squares
            squaresOfPlayers = new int[numberOfPlayers];
            for (int i = 0; i < numberOfPlayers; i++)
            {
                squaresButtons_Before[i].Text = squaresOfPlayers[i].ToString();
            }

            // View the players panels based on numberOfPlayers
            if (numberOfPlayers == 2)
            {
                Player1_Panel.Visible = true;
                Player2_Panel.Visible = true;
                Player3_Panel.Visible = false;
                Player4_Panel.Visible = false;
                Player5_Panel.Visible = false;
            }
            else if (numberOfPlayers == 3)
            {
                Player1_Panel.Visible = true;
                Player2_Panel.Visible = true;
                Player3_Panel.Visible = true;
                Player4_Panel.Visible = false;
                Player5_Panel.Visible = false;
            }
            else if(numberOfPlayers == 4)
            {
                Player1_Panel.Visible = true;
                Player2_Panel.Visible = true;
                Player3_Panel.Visible = true;
                Player4_Panel.Visible = true;
                Player5_Panel.Visible = false;
            }
            else
            {
                Player1_Panel.Visible = true;
                Player2_Panel.Visible = true;
                Player3_Panel.Visible = true;
                Player4_Panel.Visible = true;
                Player5_Panel.Visible = true;
            }

            // Assign the playerNames
            for(int i=0; i<numberOfPlayers; i++)
            {
                playerNamesList[i].Text = playerNames[i].Text;
            }

            // Assign the playerMarks
            for(int i=0; i<numberOfPlayers;i++)
            {
                pictureBoxList[i].Image = playerMarks[i].Image;
            }
        }
    }
}
