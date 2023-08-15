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

        // Intialize 2 dictionaries for ladders and snakes
        Dictionary<int, int> laddersBeforeAndAfter = new Dictionary<int, int>
        {
            {1, 38},
            {4, 14},
            {9, 31},
            {21, 42},
            {28, 84},
            {51, 67},
            {72, 91},
            {80, 99}
        };
        Dictionary<int, int> snakesBeforeAndAfter = new Dictionary<int, int>
        {
            {98, 79},
            {94, 75},
            {93, 73},
            {87, 36},
            {64, 60},
            {62, 19},
            {54, 34},
            {17, 7}
        };

        // Define Array for squares of players
        int[] numberOfSquare_Before;
        int[] numberOfSquare_After;
        int[] diceFaces = { 1, 2, 3, 4, 5, 6 };

        // Define a reference from Random class, to git random face from the dice 
        Random random = new Random();

        // Intialize some variables 
        int numberOfPlayers = 2;
        int currentPlayerTurn = 1;
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

            // Intialize and assign the array with the numberOfPlayers and their intial squares
            numberOfSquare_Before = new int[numberOfPlayers];
            numberOfSquare_After = new int[numberOfPlayers];
            for (int i = 0; i < numberOfPlayers; i++)
            {
                squaresButtons_Before[i].Text = numberOfSquare_Before[i].ToString();
                squaresButtons_After[i].Text = numberOfSquare_After[i].ToString();
            }
        }

        private void Game_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Game_Page_Load(object sender, EventArgs e)
        {
            // Call UpdateSquares_Panel to intialize our Squares_Panel
            UpdateSquares_Panel();

            // intialize player turn label with player 1 name
            lbl_Player_Turn.Text = playerNames[currentPlayerTurn-1].Text + "'s turn";
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
        private int CheckForLaddersOrSnakes(int squareNumber)
        {
            // Intialize local variables to see if we catch a ladder or snake or not
            int newSquareNumber = 0;
            bool flag = false;

            // Check if we catch any ladder, if happen we return back the newSquareNumber
            // Doing this by iterate on the laddersDictionary
            foreach (var kvp in laddersBeforeAndAfter)
            {
                if(kvp.Key == squareNumber)
                {
                    newSquareNumber = kvp.Value;
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                // We catch a ladder so we will return back without checking for a snake
                return newSquareNumber;
            }
            else
            {
                // We didn't catch a ladder so we will check if we catch any snake
                // Doing this by iterate on the snakesDictionary
                foreach (var kvp in snakesBeforeAndAfter)
                {
                    if (kvp.Key == squareNumber)
                    {
                        newSquareNumber = kvp.Value;
                    }
                }
                return newSquareNumber;
            }
        }
        private void UpdatePlayerSquares_BeforeAndAfter(int randomFace)
        {
            // Update the square number for current player 
            numberOfSquare_After[currentPlayerTurn - 1] += randomFace;

            // Check if we catch ladder or snake or not
            int newSquareNumber = CheckForLaddersOrSnakes(numberOfSquare_After[currentPlayerTurn - 1]);
            if (newSquareNumber != 0)
            {
                // We catch ladder or snake, so the square number will change based on function return
                numberOfSquare_After[currentPlayerTurn - 1] = newSquareNumber;
            }

            // Assign the new before square number by old after square number
            squaresButtons_Before[currentPlayerTurn - 1].Text = squaresButtons_After[currentPlayerTurn - 1].Text;
            
            // Assign the new after square number by the latest value after rolling
            squaresButtons_After[currentPlayerTurn - 1].Text = numberOfSquare_After[currentPlayerTurn - 1].ToString();
        }
        private void btn_Rolling_Click(object sender, EventArgs e)
        {
            // Git random face number from 1 to 6 
            int randomFace = random.Next(1, diceFaces.Length + 1);
            
            // Assign the dice picture based on the the random face we got
            switch(randomFace)
            {
                case 1:
                    Dice.Image = Properties.Resources.Dice_1_Face;
                    break;
                case 2:
                    Dice.Image = Properties.Resources.Dice_2_Face;
                    break;
                case 3:
                    Dice.Image = Properties.Resources.Dice_3_Face;
                    break;
                case 4:
                    Dice.Image = Properties.Resources.Dice_4_Face;
                    break;
                case 5:
                    Dice.Image = Properties.Resources.Dice_5_Face;
                    break;
                case 6:
                    Dice.Image = Properties.Resources.Dice_6_Face;
                    break;
            }

            // Call this function to update the before and after squares for the current player
            UpdatePlayerSquares_BeforeAndAfter(randomFace);

            // Update the current player and show his name in lbl_Player_Turn
            currentPlayerTurn = (currentPlayerTurn % numberOfPlayers) + 1;
            lbl_Player_Turn.Text = playerNames[currentPlayerTurn-1].Text + "'s turn";
        }
    }
}
