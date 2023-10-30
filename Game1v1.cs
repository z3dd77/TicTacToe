using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Game : Form
    {

        private string player1Name;
        private string player2Name;

        bool playerTurn = true;// X Turn -> true , O Turn -> false
        int turnCount = 0;
        int winStreak = 0; // Positive for X, Negative for O

        public Game(string player1Name, string player2Name)
        {
            InitializeComponent();

            this.player1Name = player1Name;
            this.player2Name = player2Name;

            // Set labels to display the player names
            P1Name.Text = player1Name;
            P2Name.Text = player2Name;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button theButtton = (Button)sender;

            if (playerTurn)
            {
                theButtton.Text = "X";
                theButtton.Enabled = false;
            }
            else
            {
                theButtton.Text = "O";
                theButtton.Enabled = false;
            }

            turnCount++;//for the draws, the maxium play is 9
            playerTurn = !playerTurn;
            checkWinner();
        }

        private void checkWinner()
        {
            /*
            foreach(Control x in Controls)//emunmeration of all controls{}
            */
            bool weHaveWinner = false;
            string winner = "";

            // Check for a win condition in all possible ways

            //---
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A2.Enabled))
                weHaveWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B2.Enabled))
                weHaveWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C2.Enabled))
                weHaveWinner = true;

            // |||
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!B1.Enabled))
                weHaveWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!B2.Enabled))
                weHaveWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!B3.Enabled))
                weHaveWinner = true;

            //X
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!B2.Enabled))
                weHaveWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!B2.Enabled))
                weHaveWinner = true;


            if (weHaveWinner)
            {
                if (playerTurn)
                {
                    winner = P2Name.Text; // Player 2 (O) wins
                    saveWinner(player2Name, "Winner");
                }
                else
                {
                    winner = P1Name.Text; // Player 1 (X) wins
                    saveWinner(player1Name, "Winner");
                }

                MessageBox.Show(winner + " Wins!", "Good Game!");
                ResetGame();
            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("Draw", "Good Game!");
                    ResetGame();
                }
            }

        }

        private void ResetGame()
        {
            List<Button> buttons;
            buttons = new List<Button> { A1, A2, A3, B1, B2, B3, C1, C2, C3 };

            foreach (Button b in buttons)
            {
                // This check is important. You can not rely on the exception handling to only process buttons.
                // If another type of control is encountered, the exception handling will cause this code to exit
                // without necessarily clearing all the buttons.

                b.Enabled = true;
                b.Text = "";


            }
        }

        private void autoNewGame()
        {
            playerTurn = true;
            turnCount = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    // This check is important. You can not rely on the exception handling to only process buttons.
                    // If another type of control is encountered, the exception handling will cause this code to exit
                    // without necessarily clearing all the buttons.
                    if (c is Button)
                    {
                        (c as Button).Enabled = true;
                        (c as Button).Text = "";
                    }
                }
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        

        private void restart_Click(object sender, EventArgs e)
        {
            List<Button> buttons;
            buttons = new List<Button> { A1, A2, A3, B1, B2, B3, C1, C2, C3 };

            foreach (Button b in buttons)
            {
                // This check is important. You can not rely on the exception handling to only process buttons.
                // If another type of control is encountered, the exception handling will cause this code to exit
                // without necessarily clearing all the buttons.

                    b.Enabled = true;
                    b.Text = "";

            }

        }
        
        private void P1label_Click(object sender, EventArgs e)
        {

        }

        private void saveWinner(string WinnerName, string WinnerStatus)
        {
            string filePath = "winnersPVP.txt";


            // Check if the file exists. If not, create it.
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = File.CreateText(filePath)) { }
            }

            // Append the winner's information to the file.
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"{WinnerName} - {WinnerStatus}");
            }
        }
    }
}
