using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private int attempts;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 2001);
            attempts = 0;
            MessageBox.Show("Let's start the game! I thought of a number from 1 to 2000. Try to guess it.", "Guess the number", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckGuess(int guess)
        {
            attempts++;

            if (guess < targetNumber)
            {
                MessageBox.Show("The hidden number is greater. Try again.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (guess > targetNumber)
            {
                MessageBox.Show("The hidden number is less. Try again.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Congratulations! You guessed the number {targetNumber} in {attempts} attempts.", "Victory!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var result = MessageBox.Show("Want to play again?", "New game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    StartNewGame();
                }
                else
                {
                    Close();
                }
            }
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(guessTextBox.Text, out int guess))
            {
                if (guess >= 1 && guess <= 2000)
                {
                    CheckGuess(guess);
                }
                else
                {
                    MessageBox.Show("Please enter a number between 1 and 2000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            guessTextBox.Clear();
            guessTextBox.Focus();
        }
    }
}