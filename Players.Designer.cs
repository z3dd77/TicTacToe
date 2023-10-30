namespace TicTacToe
{
    partial class Players
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Players));
            panel1 = new Panel();
            exitPlayerBTN = new PictureBox();
            playBTN = new PictureBox();
            player2TB = new TextBox();
            player1TB = new TextBox();
            VSlabel = new Label();
            P2label = new Label();
            P1label = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitPlayerBTN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playBTN).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(exitPlayerBTN);
            panel1.Controls.Add(playBTN);
            panel1.Controls.Add(player2TB);
            panel1.Controls.Add(player1TB);
            panel1.Controls.Add(VSlabel);
            panel1.Controls.Add(P2label);
            panel1.Controls.Add(P1label);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 324);
            panel1.TabIndex = 0;
            // 
            // exitPlayerBTN
            // 
            exitPlayerBTN.BackColor = Color.Red;
            exitPlayerBTN.Cursor = Cursors.Hand;
            exitPlayerBTN.Image = (Image)resources.GetObject("exitPlayerBTN.Image");
            exitPlayerBTN.Location = new Point(165, 256);
            exitPlayerBTN.Name = "exitPlayerBTN";
            exitPlayerBTN.Size = new Size(71, 36);
            exitPlayerBTN.SizeMode = PictureBoxSizeMode.Zoom;
            exitPlayerBTN.TabIndex = 3;
            exitPlayerBTN.TabStop = false;
            exitPlayerBTN.Click += exitPlayerBTN_Click;
            // 
            // playBTN
            // 
            playBTN.BackColor = Color.Red;
            playBTN.Cursor = Cursors.Hand;
            playBTN.Image = (Image)resources.GetObject("playBTN.Image");
            playBTN.Location = new Point(103, 249);
            playBTN.Name = "playBTN";
            playBTN.Size = new Size(91, 47);
            playBTN.SizeMode = PictureBoxSizeMode.Zoom;
            playBTN.TabIndex = 27;
            playBTN.TabStop = false;
            playBTN.Click += playBTN_Click;
            // 
            // player2TB
            // 
            player2TB.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point);
            player2TB.Location = new Point(80, 214);
            player2TB.Name = "player2TB";
            player2TB.Size = new Size(191, 28);
            player2TB.TabIndex = 26;
            player2TB.Text = "Enter Your Name";
            player2TB.TextAlign = HorizontalAlignment.Center;
            // 
            // player1TB
            // 
            player1TB.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point);
            player1TB.Location = new Point(80, 111);
            player1TB.Name = "player1TB";
            player1TB.Size = new Size(191, 28);
            player1TB.TabIndex = 25;
            player1TB.Text = "Enter Your Name";
            player1TB.TextAlign = HorizontalAlignment.Center;
            // 
            // VSlabel
            // 
            VSlabel.AutoSize = true;
            VSlabel.BackColor = Color.Red;
            VSlabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            VSlabel.ForeColor = SystemColors.ActiveCaptionText;
            VSlabel.Location = new Point(80, 153);
            VSlabel.Name = "VSlabel";
            VSlabel.Size = new Size(29, 23);
            VSlabel.TabIndex = 24;
            VSlabel.Text = "vs";
            // 
            // P2label
            // 
            P2label.AutoSize = true;
            P2label.BackColor = Color.Red;
            P2label.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            P2label.ForeColor = SystemColors.Control;
            P2label.Location = new Point(80, 188);
            P2label.Name = "P2label";
            P2label.Size = new Size(89, 23);
            P2label.TabIndex = 23;
            P2label.Text = "Player 2:";
            // 
            // P1label
            // 
            P1label.AutoSize = true;
            P1label.BackColor = Color.Red;
            P1label.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            P1label.ForeColor = SystemColors.Control;
            P1label.Location = new Point(80, 85);
            P1label.Name = "P1label";
            P1label.Size = new Size(89, 23);
            P1label.TabIndex = 22;
            P1label.Text = "Player 1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Franklin Gothic Heavy", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(34, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 43);
            label1.TabIndex = 1;
            label1.Text = "Who's Playing...?";
            // 
            // Players
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(395, 348);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Players";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Players";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exitPlayerBTN).EndInit();
            ((System.ComponentModel.ISupportInitialize)playBTN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox exitPlayerBTN;
        private TextBox player2TB;
        private TextBox player1TB;
        private Label VSlabel;
        private Label P2label;
        private Label P1label;
        private PictureBox playBTN;
    }
}