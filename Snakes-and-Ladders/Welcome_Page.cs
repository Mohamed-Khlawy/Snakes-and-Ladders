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
    public partial class Welcome_Page : Form
    {
        private List<ComboBox> comboBoxList;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Rd_btnPlayers_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            //if (radioButton == OnePlayer)
            //{
            //    lbl_Player1.Visible = true;    //1player
            //    lbl_Player2.Visible = false;
            //    lbl_Player3.Visible = false;
            //    txt_Player1.Visible = true;    //1player
            //    txt_Player2.Visible = false;
            //    txt_Player3.Visible = false;
            //    NumberOfPlayers = 1;
            //}
            NamesAndMarks_Panel.Visible = true;
            if (radioButton == TwoPlayers)
            {
                lbl_Player1.Visible = true;    //player1
                lbl_Player2.Visible = true;    //player2
                lbl_Player3.Visible = false;
                txt_Player1.Visible = true;    //player1
                txt_Player2.Visible = true;    //player2
                txt_Player3.Visible = false;
                numberOfPlayers = 2;
            }
            else if (radioButton == ThreePlayers)
            {
                lbl_Player1.Visible = true;    //player1
                lbl_Player2.Visible = true;    //player2
                lbl_Player3.Visible = true;    //player3
                txt_Player1.Visible = true;    //player1
                txt_Player2.Visible = true;    //player2
                txt_Player3.Visible = true;    //player3
                numberOfPlayers = 3;
            }
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            foreach (ComboBox c in comboBoxList)
            {
                if (c != comboBox && c.SelectedIndex == comboBox.SelectedIndex && c.SelectedIndex != -1)
                {
                    MessageBox.Show("This color mark already had choosen before",
                        "Snakes and Ladders Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox.SelectedIndex = -1;
                }
            }
        }
    }
}
