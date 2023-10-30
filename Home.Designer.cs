namespace TicTacToe
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            historyProgBar = new ProgressBar();
            singleProgBar = new ProgressBar();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            historyBTN = new PictureBox();
            multiplayerBTN = new PictureBox();
            singleplayerBTN = new PictureBox();
            progressBar1 = new ProgressBar();
            exitButton = new PictureBox();
            timerMultiplayer = new System.Windows.Forms.Timer(components);
            timerSingle = new System.Windows.Forms.Timer(components);
            timerHistory = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historyBTN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)multiplayerBTN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)singleplayerBTN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Franklin Gothic Heavy", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(203, 0);
            label1.Name = "label1";
            label1.Size = new Size(382, 81);
            label1.TabIndex = 0;
            label1.Text = "Tic-Tac-Toe ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(473, 71);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 1;
            label2.Text = "by Zee";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(historyProgBar);
            panel1.Controls.Add(singleProgBar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(historyBTN);
            panel1.Controls.Add(multiplayerBTN);
            panel1.Controls.Add(singleplayerBTN);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 395);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // historyProgBar
            // 
            historyProgBar.Location = new Point(518, 303);
            historyProgBar.Name = "historyProgBar";
            historyProgBar.Size = new Size(168, 23);
            historyProgBar.TabIndex = 11;
            // 
            // singleProgBar
            // 
            singleProgBar.Location = new Point(120, 303);
            singleProgBar.Name = "singleProgBar";
            singleProgBar.Size = new Size(168, 23);
            singleProgBar.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(566, 275);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 9;
            label5.Text = "History";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(337, 275);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 8;
            label4.Text = "Multiplayer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(132, 275);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 7;
            label3.Text = "Singleplayer";
            // 
            // historyBTN
            // 
            historyBTN.Cursor = Cursors.Hand;
            historyBTN.Image = (Image)resources.GetObject("historyBTN.Image");
            historyBTN.Location = new Point(518, 162);
            historyBTN.Name = "historyBTN";
            historyBTN.Size = new Size(168, 110);
            historyBTN.SizeMode = PictureBoxSizeMode.Zoom;
            historyBTN.TabIndex = 6;
            historyBTN.TabStop = false;
            historyBTN.Click += historyBTN_Click;
            // 
            // multiplayerBTN
            // 
            multiplayerBTN.Cursor = Cursors.Hand;
            multiplayerBTN.Image = (Image)resources.GetObject("multiplayerBTN.Image");
            multiplayerBTN.Location = new Point(294, 126);
            multiplayerBTN.Name = "multiplayerBTN";
            multiplayerBTN.Size = new Size(218, 146);
            multiplayerBTN.SizeMode = PictureBoxSizeMode.Zoom;
            multiplayerBTN.TabIndex = 5;
            multiplayerBTN.TabStop = false;
            multiplayerBTN.Click += multiplayerBTN_Click;
            // 
            // singleplayerBTN
            // 
            singleplayerBTN.Cursor = Cursors.Hand;
            singleplayerBTN.Image = (Image)resources.GetObject("singleplayerBTN.Image");
            singleplayerBTN.Location = new Point(120, 162);
            singleplayerBTN.Name = "singleplayerBTN";
            singleplayerBTN.Size = new Size(168, 110);
            singleplayerBTN.SizeMode = PictureBoxSizeMode.Zoom;
            singleplayerBTN.TabIndex = 4;
            singleplayerBTN.TabStop = false;
            singleplayerBTN.Click += singleplayerBTN_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(294, 303);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(218, 23);
            progressBar1.TabIndex = 3;
            progressBar1.Click += progressBar1_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Red;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(725, 3);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(69, 27);
            exitButton.SizeMode = PictureBoxSizeMode.Zoom;
            exitButton.TabIndex = 2;
            exitButton.TabStop = false;
            exitButton.Click += pictureBox1_Click;
            // 
            // timerMultiplayer
            // 
            timerMultiplayer.Tick += timer1_Tick;
            // 
            // timerSingle
            // 
            timerSingle.Tick += timerSingle_Tick;
            // 
            // timerHistory
            // 
            timerHistory.Tick += timerHistory_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 419);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)historyBTN).EndInit();
            ((System.ComponentModel.ISupportInitialize)multiplayerBTN).EndInit();
            ((System.ComponentModel.ISupportInitialize)singleplayerBTN).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox exitButton;
        private PictureBox singleplayerBTN;
        private ProgressBar progressBar1;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox historyBTN;
        private PictureBox multiplayerBTN;
        private System.Windows.Forms.Timer timerMultiplayer;
        private ProgressBar historyProgBar;
        private ProgressBar singleProgBar;
        private System.Windows.Forms.Timer timerSingle;
        private System.Windows.Forms.Timer timerHistory;
    }
}