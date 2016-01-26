using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowHead_Click(object sender, EventArgs e)
        {
            pictureBoxHeads.Show();
            pictureBoxTails.Hide();

        }

        private void buttonShowTail_Click(object sender, EventArgs e)
        {
            pictureBoxHeads.Hide();
            pictureBoxTails.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
