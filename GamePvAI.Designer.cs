namespace TicTacToe
{
    partial class GamePvAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePvAI));
            panel1 = new Panel();
            AIrestart = new Label();
            c3 = new Button();
            c2 = new Button();
            c1 = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            a3 = new Button();
            a2 = new Button();
            a1 = new Button();
            AIvsLabel = new Label();
            CPULabel = new Label();
            playerNamevsAI = new Label();
            AIplayerlabel = new Label();
            PvAIexitBTN = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PvAIexitBTN).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(AIrestart);
            panel1.Controls.Add(c3);
            panel1.Controls.Add(c2);
            panel1.Controls.Add(c1);
            panel1.Controls.Add(b3);
            panel1.Controls.Add(b2);
            panel1.Controls.Add(b1);
            panel1.Controls.Add(a3);
            panel1.Controls.Add(a2);
            panel1.Controls.Add(a1);
            panel1.Controls.Add(AIvsLabel);
            panel1.Controls.Add(CPULabel);
            panel1.Controls.Add(playerNamevsAI);
            panel1.Controls.Add(AIplayerlabel);
            panel1.Controls.Add(PvAIexitBTN);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 471);
            panel1.TabIndex = 0;
            // 
            // AIrestart
            // 
            AIrestart.AutoSize = true;
            AIrestart.BackColor = Color.Red;
            AIrestart.Cursor = Cursors.Hand;
            AIrestart.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AIrestart.ForeColor = SystemColors.Control;
            AIrestart.Location = new Point(109, 392);
            AIrestart.Name = "AIrestart";
            AIrestart.Size = new Size(72, 23);
            AIrestart.TabIndex = 33;
            AIrestart.Text = "Restart";
            AIrestart.Click += AIrestart_Click;
            // 
            // c3
            // 
            c3.BackColor = Color.Red;
            c3.Cursor = Cursors.Hand;
            c3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            c3.ForeColor = Color.Red;
            c3.Location = new Point(187, 299);
            c3.Name = "c3";
            c3.Size = new Size(72, 66);
            c3.TabIndex = 32;
            c3.UseVisualStyleBackColor = false;
            c3.Click += buttonClick;
            // 
            // c2
            // 
            c2.BackColor = Color.Red;
            c2.Cursor = Cursors.Hand;
            c2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            c2.ForeColor = Color.Red;
            c2.Location = new Point(109, 299);
            c2.Name = "c2";
            c2.Size = new Size(72, 66);
            c2.TabIndex = 31;
            c2.UseVisualStyleBackColor = false;
            c2.Click += buttonClick;
            // 
            // c1
            // 
            c1.BackColor = Color.Red;
            c1.Cursor = Cursors.Hand;
            c1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            c1.ForeColor = Color.Red;
            c1.Location = new Point(31, 299);
            c1.Name = "c1";
            c1.Size = new Size(72, 66);
            c1.TabIndex = 30;
            c1.UseVisualStyleBackColor = false;
            c1.Click += buttonClick;
            // 
            // b3
            // 
            b3.BackColor = Color.Red;
            b3.Cursor = Cursors.Hand;
            b3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            b3.ForeColor = Color.Red;
            b3.Location = new Point(187, 227);
            b3.Name = "b3";
            b3.Size = new Size(72, 66);
            b3.TabIndex = 29;
            b3.UseVisualStyleBackColor = false;
            b3.Click += buttonClick;
            // 
            // b2
            // 
            b2.BackColor = Color.Red;
            b2.Cursor = Cursors.Hand;
            b2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            b2.ForeColor = Color.Red;
            b2.Location = new Point(109, 227);
            b2.Name = "b2";
            b2.Size = new Size(72, 66);
            b2.TabIndex = 28;
            b2.UseVisualStyleBackColor = false;
            b2.Click += buttonClick;
            // 
            // b1
            // 
            b1.BackColor = Color.Red;
            b1.Cursor = Cursors.Hand;
            b1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            b1.ForeColor = Color.Red;
            b1.Location = new Point(31, 227);
            b1.Name = "b1";
            b1.Size = new Size(72, 66);
            b1.TabIndex = 27;
            b1.UseVisualStyleBackColor = false;
            b1.Click += buttonClick;
            // 
            // a3
            // 
            a3.BackColor = Color.Red;
            a3.Cursor = Cursors.Hand;
            a3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            a3.ForeColor = Color.Red;
            a3.Location = new Point(187, 155);
            a3.Name = "a3";
            a3.Size = new Size(72, 66);
            a3.TabIndex = 26;
            a3.UseVisualStyleBackColor = false;
            a3.Click += buttonClick;
            // 
            // a2
            // 
            a2.BackColor = Color.Red;
            a2.Cursor = Cursors.Hand;
            a2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            a2.ForeColor = Color.Red;
            a2.Location = new Point(109, 155);
            a2.Name = "a2";
            a2.Size = new Size(72, 66);
            a2.TabIndex = 25;
            a2.UseVisualStyleBackColor = false;
            a2.Click += buttonClick;
            // 
            // a1
            // 
            a1.BackColor = Color.Red;
            a1.Cursor = Cursors.Hand;
            a1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            a1.ForeColor = Color.Red;
            a1.Location = new Point(31, 155);
            a1.Name = "a1";
            a1.Size = new Size(72, 66);
            a1.TabIndex = 24;
            a1.UseVisualStyleBackColor = false;
            a1.Click += buttonClick;
            // 
            // AIvsLabel
            // 
            AIvsLabel.AutoSize = true;
            AIvsLabel.BackColor = SystemColors.ActiveCaptionText;
            AIvsLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AIvsLabel.ForeColor = SystemColors.Control;
            AIvsLabel.Location = new Point(31, 77);
            AIvsLabel.Name = "AIvsLabel";
            AIvsLabel.Size = new Size(29, 23);
            AIvsLabel.TabIndex = 23;
            AIvsLabel.Text = "vs";
            // 
            // CPULabel
            // 
            CPULabel.AutoSize = true;
            CPULabel.BackColor = SystemColors.ActiveCaptionText;
            CPULabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CPULabel.ForeColor = Color.Red;
            CPULabel.Location = new Point(31, 100);
            CPULabel.Name = "CPULabel";
            CPULabel.Size = new Size(141, 23);
            CPULabel.TabIndex = 22;
            CPULabel.Text = "Computer (AI)";
            // 
            // playerNamevsAI
            // 
            playerNamevsAI.AutoSize = true;
            playerNamevsAI.BackColor = SystemColors.ActiveCaptionText;
            playerNamevsAI.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            playerNamevsAI.ForeColor = Color.Red;
            playerNamevsAI.Location = new Point(115, 57);
            playerNamevsAI.Name = "playerNamevsAI";
            playerNamevsAI.Size = new Size(25, 23);
            playerNamevsAI.TabIndex = 21;
            playerNamevsAI.Text = "...";
            // 
            // AIplayerlabel
            // 
            AIplayerlabel.AutoSize = true;
            AIplayerlabel.BackColor = SystemColors.ActiveCaptionText;
            AIplayerlabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AIplayerlabel.ForeColor = SystemColors.Control;
            AIplayerlabel.Location = new Point(31, 57);
            AIplayerlabel.Name = "AIplayerlabel";
            AIplayerlabel.Size = new Size(78, 23);
            AIplayerlabel.TabIndex = 20;
            AIplayerlabel.Text = "Player :";
            // 
            // PvAIexitBTN
            // 
            PvAIexitBTN.Cursor = Cursors.Hand;
            PvAIexitBTN.Image = (Image)resources.GetObject("PvAIexitBTN.Image");
            PvAIexitBTN.Location = new Point(245, 1);
            PvAIexitBTN.Name = "PvAIexitBTN";
            PvAIexitBTN.Size = new Size(65, 31);
            PvAIexitBTN.SizeMode = PictureBoxSizeMode.Zoom;
            PvAIexitBTN.TabIndex = 0;
            PvAIexitBTN.TabStop = false;
            PvAIexitBTN.Click += PvAIexitBTN_Click;
            // 
            // GamePvAI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(320, 495);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GamePvAI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GamePvAI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PvAIexitBTN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox PvAIexitBTN;
        private Label AIplayerlabel;
        private Label CPULabel;
        private Label playerNamevsAI;
        private Label AIvsLabel;
        private Button c3;
        private Button c2;
        private Button c1;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button a3;
        private Button a2;
        private Button a1;
        private Label AIrestart;
        private System.Windows.Forms.Timer timer1;
    }
}