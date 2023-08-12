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
        public Game_Page()
        {
            InitializeComponent();
        }

        private void Game_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
