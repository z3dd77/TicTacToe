using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicTacToe
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            LoadWinnersDataOnFormLoad();
            LWDOFormLoad();
        }

        // LoadWinnersDataOnFormLoad & LoadWinnersData == PvAI
        // LWDOFormLoad & LoadWD == PvP

        private void LoadWinnersDataOnFormLoad()
        {
            // Define DataGridView columns if not already defined.
            if (PvAIdgv.Columns.Count == 0)
            {
                PvAIdgv.Columns.Add("WinnerName", "Winner Name");
                PvAIdgv.Columns.Add("WinnerStatus", "Winner Status");
            }
            // Load and display winners' data.
            LoadWinnersData();
        }

        private void LWDOFormLoad()
        {
            // Define DataGridView columns if not already defined.
            if (PvPdgv.Columns.Count == 0)
            {
                PvPdgv.Columns.Add("WinnerName", "Winner Name");
                PvPdgv.Columns.Add("WinnerStatus", "Winner Status");
            }
            // Load and display winners' data.
            LoadWD();
        }

        private void LoadWinnersData()
        {
            string filePath = "winners.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // Split the line into date/time, winner's name, and winner's status.
                    string[] parts = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2)
                    {
                        string winnerName = parts[0].Trim();
                        string winnerStatus = parts[1].Trim();

                        // Add the data to the DataGridView.
                        PvAIdgv.Rows.Add(winnerName, winnerStatus);
                    }
                }
            }

        }

        private void LoadWD()
        {
            string filePath = "winnersPVP.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // Split the line into date/time, winner's name, and winner's status.
                    string[] parts = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2)
                    {
                        string WinnerName = parts[0].Trim();
                        string WinnerStatus = parts[1].Trim();

                        // Add the data to the DataGridView.
                        PvPdgv.Rows.Add(WinnerName, WinnerStatus);
                    }
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitHistoryButton_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }
    }
}
