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
    public partial class frmGuessTheNumber : Form
    {
        // Number user is trying to guess
        private int theNumber;

        // Give user limited tries to guess
        private int triesLeft;

        public frmGuessTheNumber()
        {
            InitializeComponent();
        }

        // Method to check whether user's guess is too high or too low
        public void checkGuess()
        {
            // Gets the user's guess
            String guessText = txtGuess.Text.ToString();
            String message = "";

            try
            {
                // Checks the guess
                int guess = int.Parse(guessText);

                // Count this as one try
                triesLeft--;

                // Too high
                if (guess > theNumber)
                {
                    message = guess + " was too high. Guess again.";
                    lblOutput.Text = message;
                    lblTries.Text = "You have " + triesLeft + " tries remaining";
                }
                // Too low
                else if (guess < theNumber)
                {
                    message = guess + " was too low. Guess again.";
                    lblOutput.Text = message;
                    lblTries.Text = "You have " + triesLeft + " tries remaining";
                }

                // Correct
                else
                {
                    message = guess + " was correct. You win! Let's play again!";
                    lblOutput.Text = message;
                    if (lblGuess.Text.ToString() == "Guess a number between 1 and 10:")
                    {
                        lblTries.Text = "You guessed in " + (4 - triesLeft) + " tries.";
                    }
                    else if (lblGuess.Text.ToString() == "Guess a number between 1 and 100:")
                    {
                        lblTries.Text = "You guessed in " + (7 - triesLeft) + " tries.";
                    }
                    else if (lblGuess.Text.ToString() == "Guess a number between 1 and 1000:")
                    {
                        lblTries.Text = "You guessed in " + (9 - triesLeft) + " tries.";
                    }
                    DialogResult result = MessageBox.Show("Play again?", "You win!", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                    if (result == DialogResult.Cancel || result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else if (result == DialogResult.Yes)
                    {
                        frmGameLevel gameLevel = new frmGameLevel();
                        gameLevel.ShowDialog();
                        newGame();
                    }
                }

                if (triesLeft <= 0)
                {
                    DialogResult result = MessageBox.Show("You ran out of tries. The number was " + theNumber
                            + "\nPlay again?", "You lose!", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Cancel || result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else if(result == DialogResult.Yes)
                    {
                        frmGameLevel gameLevel = new frmGameLevel();
                        gameLevel.ShowDialog();
                        newGame();
                    }
                }
            }
            catch (Exception e)
            {
                lblOutput.Text = "Enter a whole number in the range listed above.";
            }
            finally
            {
                txtGuess.Focus();
                txtGuess.SelectAll();
            }
        }

        // Sets a new random number between 1 and 10, 1 and 100, or 1 and 1000
        public void newGame()
        {
            txtGuess.Text = "";
            txtGuess.Focus();

            if(Level.level == "easy")
            {
                Random number = new Random();
                theNumber = number.Next(1, 10);
                lblTries.Text = "You have 4 tries remaining";
                lblGuess.Text = "Guess a number between 1 and 10:";
                lblOutput.Text = "Enter a number above, and click 'Guess'.";
                triesLeft = 4;
            }
            else if(Level.level == "medium")
            {
                Random number = new Random();
                theNumber = number.Next(1, 100);
                lblTries.Text = "You have 7 tries remaining";
                lblGuess.Text = "Guess a number between 1 and 100:";
                lblOutput.Text = "Enter a number above, and click 'Guess'.";
                triesLeft = 7;
            }
            else if (Level.level == "hard")
            {
                Random number = new Random();
                theNumber = number.Next(1, 1000);
                lblTries.Text = "You have 9 tries remaining";
                lblGuess.Text = "Guess a number between 1 and 1000:";
                lblOutput.Text = "Enter a number above, and click 'Guess'.";
                triesLeft = 9;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            checkGuess();
        }

        private void frmGuessTheNumber_Load(object sender, EventArgs e)
        {
            frmGameLevel gameLevel = new frmGameLevel();
            gameLevel.ShowDialog();
            this.Hide();
            newGame();
        }
    }
}
