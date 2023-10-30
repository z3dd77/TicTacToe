using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.Devices;
using static TicTacToe.GamePvAI;
using System.IO;

namespace TicTacToe
{
    public partial class GamePvAI : Form
    {

        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        Random rdm = new Random();
        List<Button> buttons;

        private string playerName;
        private bool playerTurn = true;
        private int turnCount = 0;
        private Random random = new Random(); // For CPU's random moves

        public GamePvAI(string playerName)
        {
            InitializeComponent();

            this.playerName = playerName;
            playerNamevsAI.Text = playerName;

            RestartGame();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            buttons.Remove(button);

            // Increment the turn count
            turnCount++;

            CheckGame();
            timer1.Start();

            CPUmove();
        }

        private void CheckGame()
        {

            if ((a1.Text == "X" && a2.Text == "X" && a3.Text == "X")
                || (b1.Text == "X" && b2.Text == "X" && b3.Text == "X")
                || (c1.Text == "X" && c2.Text == "X" && c3.Text == "X")
                || (a1.Text == "X" && b1.Text == "X" && c1.Text == "X")
                || (a2.Text == "X" && b2.Text == "X" && c2.Text == "X")
                || (a3.Text == "X" && b3.Text == "X" && c3.Text == "X")
                || (a1.Text == "X" && b2.Text == "X" && c3.Text == "X")
                || (a3.Text == "X" && b2.Text == "X" && c1.Text == "X"))
            {
                turnCount++;
                timer1.Stop();
                MessageBox.Show(playerName + " Wins!", "Good Game!");
                SaveWinner(playerName, "Player");
                RestartGame();
            }
            else if ((a1.Text == "O" && a2.Text == "O" && a3.Text == "O")
                || (b1.Text == "O" && b2.Text == "O" && b3.Text == "O")
                || (c1.Text == "O" && c2.Text == "O" && c3.Text == "O")
                || (a1.Text == "O" && b1.Text == "O" && c1.Text == "O")
                || (a2.Text == "O" && b2.Text == "O" && c2.Text == "O")
                || (a3.Text == "O" && b3.Text == "O" && c3.Text == "O")
                || (a1.Text == "O" && b2.Text == "O" && c3.Text == "O")
                || (a3.Text == "O" && b2.Text == "O" && c1.Text == "O"))
            {
                turnCount++;
                timer1.Stop();
                MessageBox.Show("CPU Wins!", "Good Game!");
                SaveWinner("CPU", "CPU");
                RestartGame();
            }
            else if (turnCount == 9)
            { 
                timer1.Stop();
                MessageBox.Show("Draw!", "Good Game!");
                RestartGame();

            }

        }

        private void RestartGame()
        {
            buttons = new List<Button> { a1, a2, a3, b1, b2, b3, c1, c2, c3 };

            foreach (Button X in buttons)
            {
                X.Enabled = true;
                X.Text = "";
                X.BackColor = Color.Red;
            }
        }
        private void AutoNewGame()
        {
            // Reset the game for a new round
            playerTurn = true;
            turnCount = 0;

            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                    button.Text = "";
                }
            }
        }

        private void PvAIexitBTN_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            this.Hide();
            obj.Show();
        }

        private void AIrestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CPUmove(object sender, EventArgs e)
        {
            CPUmove();
        }

        private void CPUmove()
        {
            if (buttons.Count > 0)
            {
                int index = rdm.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons.RemoveAt(index);

                // Increment the turn count after each CPU turn
                turnCount++;

                CheckGame();
                timer1.Stop();
            }
        }

        private void SaveWinner(string winnerName, string winnerStatus)
        {
            string filePath = "winners.txt";

            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Check if the file exists. If not, create it.
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = File.CreateText(filePath)) { }
            }

            // Append the winner's information to the file.
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"{currentTime} - {winnerName} - {winnerStatus}");
                writer.WriteLine($"{winnerName} - {winnerStatus}");
            }
        }
    }
}
