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
    public partial class PlayerVsAI : Form
    {
        public PlayerVsAI()
        {
            InitializeComponent();
        }

        private void playernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AIplayBTN_Click(object sender, EventArgs e)
        {
            string playerName = playerNameTB.Text; // Get the player's name from a TextBox, adjust as needed

            GamePvAI game = new GamePvAI(playerName);
            game.Show();
            this.Hide(); // Hide the MainForm or close it, depending on your design
        }

        private void exitAIplayerBTN_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }
    }
}
