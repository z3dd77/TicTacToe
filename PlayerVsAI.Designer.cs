namespace TicTacToe
{
    partial class PlayerVsAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerVsAI));
            panel1 = new Panel();
            exitAIplayerBTN = new PictureBox();
            AIplayBTN = new PictureBox();
            label2 = new Label();
            aiVSlabel = new Label();
            playerNameTB = new TextBox();
            playernameLabel = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitAIplayerBTN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AIplayBTN).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(exitAIplayerBTN);
            panel1.Controls.Add(AIplayBTN);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(aiVSlabel);
            panel1.Controls.Add(playerNameTB);
            panel1.Controls.Add(playernameLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 324);
            panel1.TabIndex = 0;
            // 
            // exitAIplayerBTN
            // 
            exitAIplayerBTN.BackColor = Color.Red;
            exitAIplayerBTN.Cursor = Cursors.Hand;
            exitAIplayerBTN.Image = (Image)resources.GetObject("exitAIplayerBTN.Image");
            exitAIplayerBTN.Location = new Point(165, 256);
            exitAIplayerBTN.Name = "exitAIplayerBTN";
            exitAIplayerBTN.Size = new Size(71, 36);
            exitAIplayerBTN.SizeMode = PictureBoxSizeMode.Zoom;
            exitAIplayerBTN.TabIndex = 30;
            exitAIplayerBTN.TabStop = false;
            exitAIplayerBTN.Click += exitAIplayerBTN_Click;
            // 
            // AIplayBTN
            // 
            AIplayBTN.BackColor = Color.Red;
            AIplayBTN.Cursor = Cursors.Hand;
            AIplayBTN.Image = (Image)resources.GetObject("AIplayBTN.Image");
            AIplayBTN.Location = new Point(103, 249);
            AIplayBTN.Name = "AIplayBTN";
            AIplayBTN.Size = new Size(91, 47);
            AIplayBTN.SizeMode = PictureBoxSizeMode.Zoom;
            AIplayBTN.TabIndex = 29;
            AIplayBTN.TabStop = false;
            AIplayBTN.Click += AIplayBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(80, 85);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 28;
            label2.Text = "Player :";
            // 
            // aiVSlabel
            // 
            aiVSlabel.AutoSize = true;
            aiVSlabel.BackColor = Color.Red;
            aiVSlabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            aiVSlabel.ForeColor = SystemColors.ActiveCaptionText;
            aiVSlabel.Location = new Point(80, 153);
            aiVSlabel.Name = "aiVSlabel";
            aiVSlabel.Size = new Size(29, 23);
            aiVSlabel.TabIndex = 27;
            aiVSlabel.Text = "vs";
            // 
            // playerNameTB
            // 
            playerNameTB.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point);
            playerNameTB.Location = new Point(80, 111);
            playerNameTB.Name = "playerNameTB";
            playerNameTB.Size = new Size(191, 28);
            playerNameTB.TabIndex = 26;
            playerNameTB.Text = "Enter Your Name";
            playerNameTB.TextAlign = HorizontalAlignment.Center;
            // 
            // playernameLabel
            // 
            playernameLabel.AutoSize = true;
            playernameLabel.BackColor = Color.Red;
            playernameLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            playernameLabel.ForeColor = SystemColors.Control;
            playernameLabel.Location = new Point(80, 189);
            playernameLabel.Name = "playernameLabel";
            playernameLabel.Size = new Size(141, 23);
            playernameLabel.TabIndex = 23;
            playernameLabel.Text = "Computer (AI)";
            playernameLabel.Click += playernameLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Franklin Gothic Heavy", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(31, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 43);
            label1.TabIndex = 2;
            label1.Text = "Who's Playing...?";
            // 
            // PlayerVsAI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(395, 348);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlayerVsAI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayerVsAI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exitAIplayerBTN).EndInit();
            ((System.ComponentModel.ISupportInitialize)AIplayBTN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label playernameLabel;
        private TextBox playerNameTB;
        private Label aiVSlabel;
        private Label label2;
        private PictureBox AIplayBTN;
        private PictureBox exitAIplayerBTN;
    }
}