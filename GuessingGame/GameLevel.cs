using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class frmGameLevel : Form
    {
        public frmGameLevel()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            frmGuessTheNumber GuessingGame = new frmGuessTheNumber();
            Level.level = "easy";
            this.Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            frmGuessTheNumber GuessingGame = new frmGuessTheNumber();
            Level.level = "medium";
            this.Close();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            frmGuessTheNumber GuessingGame = new frmGuessTheNumber();
            Level.level = "hard";
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
