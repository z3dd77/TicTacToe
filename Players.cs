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
    public partial class Players : Form
    {
        public Players()
        {
            InitializeComponent();
        }

        public string Player1Name { get; private set; }
        public string Player2Name { get; private set; }

        private void exitPlayerBTN_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            this.Hide();
            obj.Show();
        }

        private void playBTN_Click(object sender, EventArgs e)
        {
            if (player1TB.Text == "" || player2TB.Text == "" || player1TB.Text == "Enter Your Name" || player2TB.Text == "Enter Your Name")
            {
                MessageBox.Show("Player Names Cannot Be Empty", "Bruh, what are you doing?!");
            }
            else
            {
                Player1Name = player1TB.Text; // Assuming player1TextBox is the TextBox for Player 1's name
                Player2Name = player2TB.Text; // Assuming player2TextBox is the TextBox for Player 2's name

                Game obj = new Game(Player1Name, Player2Name); // Pass the names to the Game constructor
                this.Hide();
                obj.Show();
            }
        }
    }
}
