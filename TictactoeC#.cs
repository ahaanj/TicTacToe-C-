using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeC_
{
    public partial class Form1 : Form
    {
        // Constructor for initializing the form and updating the turn label
        public Form1()
        {
            InitializeComponent();
            UpdateTurnLabel(); // Initialize the turn label
        }

        // Array to represent the game board
        String[] gameBoard = new string[9];

        // Variable to keep track of the current turn
        int currentTurn = 0;

        // Method to return the symbol ("O" or "X") based on the turn number
        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        // Method to check if there is a winner
        public void checkForWinner()
        {
            // Loop through possible winning combinations
            for (int i = 0; i < 8; i++)
            {
                String combination = "";

                // Switch statement to check each winning combination
                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                }

                // Check if "O" has won
                if (combination.Equals("OOO"))
                {
                    MessageBox.Show("O has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reset();
                    return; // Exit the method to avoid checking for a draw
                }
                // Check if "X" has won
                else if (combination.Equals("XXX"))
                {
                    MessageBox.Show("X has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reset();
                    return; // Exit the method to avoid checking for a draw
                }
            }

            // Check for a draw only if no winner is found
            checkDraw();
        }

        // Method to reset the game
        public void reset()
        {
            // Clear all buttons
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            // Reset button colors
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;

            // Reset game board and turn counter
            gameBoard = new string[9];
            currentTurn = 0;
            UpdateTurnLabel(); // Reset the turn label
        }

        // Method to check if the game is a draw
        public void checkDraw()
        {
            int counter = 0;

            // Count non-empty cells in the game board
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null)
                {
                    counter++;
                }
            }

            // If all cells are filled and no winner, declare a draw
            if (counter == 9)
            {
                MessageBox.Show("The game is a draw!", "No winner ):", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reset();
            }
        }

        // Method to update the turn label with the current turn
        private void UpdateTurnLabel()
        {
            turnLabel.Text = $"Current Turn: {returnSymbol(currentTurn + 1)}";
        }

        // Event handler for form load event
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Event handler for button1 click event
        private void button1_Click(object sender, EventArgs e)
        {
            // If the button is not already clicked
            if (string.IsNullOrEmpty(button1.Text))
            {
                currentTurn++;
                gameBoard[0] = returnSymbol(currentTurn); // Set the symbol on the game board
                button1.Text = gameBoard[0]; // Set the button text
                button1.ForeColor = gameBoard[0] == "X" ? Color.White : Color.Brown; // Set the button color based on symbol
                checkForWinner(); // Check for a winner
                UpdateTurnLabel(); // Update the turn label
            }
        }

        // Event handler for button2 click event
        private void button2_Click(object sender, EventArgs e)
        {
            // If the button is not already clicked
            if (string.IsNullOrEmpty(button2.Text))
            {
                currentTurn++;
                gameBoard[1] = returnSymbol(currentTurn); // Set the symbol on the game board
                button2.Text = gameBoard[1]; // Set the button text
                button2.ForeColor = gameBoard[1] == "X" ? Color.White : Color.Brown; // Set the button color based on symbol
                checkForWinner(); // Check for a winner
                UpdateTurnLabel(); // Update the turn label
            }
        }

        // Event handler for button3 click event
        private void button3_Click(object sender, EventArgs e)
        {
            // If the button is not already clicked
            if (string.IsNullOrEmpty(button3.Text))
            {
                currentTurn++;
                gameBoard[2] = returnSymbol(currentTurn); // Set the symbol on the game board
                button3.Text = gameBoard[2]; // Set the button text
                button3.ForeColor = gameBoard[2] == "X" ? Color.White : Color.Brown; // Set the button color based on symbol
                checkForWinner(); // Check for a winner
                UpdateTurnLabel(); // Update the turn label
            }
        }

        // Event handler for button4 click event
        private void button4_Click(object sender, EventArgs e)
        {
            // If the button is not already clicked
            if (string.IsNullOrEmpty(button4.Text))
            {
                currentTurn++;
                gameBoard[3] = returnSymbol(currentTurn); // Set the symbol on the game board
                button4.Text = gameBoard[3]; // Set the button text
                button4.ForeColor = gameBoard[3] == "X" ? Color.White : Color.Brown; // Set the button color based on symbol
                checkForWinner(); // Check for a winner
                UpdateTurnLabel(); // Update the turn label
            }
        }

        // Event handler for button5 click event
        private void button5_Click(object sender, EventArgs e)
        {
            // If the button is not already clicked
            if (string.IsNullOrEmpty(button5.Text))
            {
                currentTurn++;
                gameBoard[4] = returnSymbol(currentTurn); // Set the symbol on the game board
                button5.Text = gameBoard[4]; // Set the button text
                button5.ForeColor = gameBoard[4] == "X" ? Color.White : Color.Brown; // Set the button color based on symbol
                checkForWinner(); // Check for a winner
                UpdateTurnLabel(); // Update the turn label
            }
        }

        // Event handler for button6 click event
        private void button6_Click(object sender, EventArgs e)
        {
            // If the button is not already clicked
            if (string.IsNullOrEmpty(button6.Text))
            {
                currentTurn++;
                gameBoard[5] = returnSymbol(currentTurn); // Set the symbol on the game board
                button6.Text = gameBoard[5]; // Set the button text
                button6.ForeColor = gameBoard[5] == "X" ? Color.White : Color.Brown; // Set the button color based on symbol
                checkForWinner(); // Check for a winner
                UpdateTurnLabel(); // Update the turn label
            }
        }

        // Event handler for button7 click event
        private void button7_Click(object sender, EventArgs e)
        {
            // If the button is not already clicked
            if (string.IsNullOrEmpty(button7.Text))
            {
                currentTurn++;
                gameBoard[6] = returnSymbol(currentTurn); // Set the symbol on the game board
                button7.Text = gameBoard[6]; // Set the button text
                button7.ForeColor = gameBoard[6] == "X" ? Color.White : Color.Brown; // Set the button color based on symbol
                checkForWinner(); // Check for a winner
                UpdateTurnLabel(); // Update the turn label
            }
        }

        // Event handler for button8 click event
        private void button8_Click(object sender, EventArgs e)
        {
            // If the button is not already clicked
            if (string.IsNullOrEmpty(button8.Text))
            {
                currentTurn++;
                gameBoard[7] = returnSymbol(currentTurn); // Set the symbol on the game board
                button8.Text = gameBoard[7]; // Set the button text
                button8.ForeColor = gameBoard[7] == "X" ? Color.White : Color.Brown; // Set the button color based on symbol
                checkForWinner(); // Check for a winner
                UpdateTurnLabel(); // Update the turn label
            }
        }

        // Event handler for button9 click event
        private void button9_Click(object sender, EventArgs e)
        {
            // If the button is not already clicked
            if (string.IsNullOrEmpty(button9.Text))
            {
                currentTurn++;
                gameBoard[8] = returnSymbol(currentTurn); // Set the symbol on the game board
                button9.Text = gameBoard[8]; // Set the button text
                button9.ForeColor = gameBoard[8] == "X" ? Color.White : Color.Brown; // Set the button color based on symbol
                checkForWinner(); // Check for a winner
                UpdateTurnLabel(); // Update the turn label
            }
        }

        // Event handler for label1 click event (if needed)
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
