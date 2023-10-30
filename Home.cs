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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        int start = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void singleplayerBTN_Click(object sender, EventArgs e)
        {
            // Start the progress bar animation
            timerSingle.Start();

            // Disable the "Proceed" button to prevent multiple clicks
            singleplayerBTN.Enabled = false;

        }

        private void multiplayerBTN_Click(object sender, EventArgs e)
        {
            // Start the progress bar animation
            timerMultiplayer.Start();

            // Disable the "Proceed" button to prevent multiple clicks
            multiplayerBTN.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            progressBar1.Value = start;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timerMultiplayer.Stop();
                progressBar1.Value = 0;

                Players obj = new Players();
                obj.Show();
                this.Hide();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timerMultiplayer.Interval = 10;
            timerSingle.Interval = 10;
            timerHistory.Interval = 10;
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void timerSingle_Tick(object sender, EventArgs e)
        {
            start += 1;
            singleProgBar.Value = start;
            if (singleProgBar.Value >= singleProgBar.Maximum)
            {
                timerSingle.Stop();
                singleProgBar.Value = 0;

                PlayerVsAI obj = new PlayerVsAI();
                obj.Show();
                this.Hide();
            }
        }

        private void historyBTN_Click(object sender, EventArgs e)
        {
            History obj = new History();
            obj.Show();
            this.Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timerHistory_Tick(object sender, EventArgs e)
        {
            start += 1;
            historyProgBar.Value = start;
            if (historyProgBar.Value >= historyProgBar.Maximum)
            {
                timerSingle.Stop();
                historyProgBar.Value = 0;

                History obj = new History();
                obj.Show();
                this.Hide();
            }
        }
    }
}
