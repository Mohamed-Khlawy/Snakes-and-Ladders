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
    public partial class Welcome_Image : Form
    {
        public Welcome_Image()
        {
            Task.Delay(2000).ContinueWith(_ =>
            {
                Welcome_Page welcome_Page = new Welcome_Page();
                welcome_Page.Show();
                this.Hide();
            }, TaskScheduler.FromCurrentSynchronizationContext());
            InitializeComponent();
        }
    }
}
