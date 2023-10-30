namespace TicTacToe
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            panel1 = new Panel();
            P2Name = new Label();
            P1Name = new Label();
            VSlabel = new Label();
            P2label = new Label();
            P1label = new Label();
            restart = new Label();
            pictureBox1 = new PictureBox();
            C3 = new Button();
            C2 = new Button();
            C1 = new Button();
            B3 = new Button();
            B2 = new Button();
            B1 = new Button();
            A3 = new Button();
            A1 = new Button();
            A2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(P2Name);
            panel1.Controls.Add(P1Name);
            panel1.Controls.Add(VSlabel);
            panel1.Controls.Add(P2label);
            panel1.Controls.Add(P1label);
            panel1.Controls.Add(restart);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(C3);
            panel1.Controls.Add(C2);
            panel1.Controls.Add(C1);
            panel1.Controls.Add(B3);
            panel1.Controls.Add(B2);
            panel1.Controls.Add(B1);
            panel1.Controls.Add(A3);
            panel1.Controls.Add(A1);
            panel1.Controls.Add(A2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 471);
            panel1.TabIndex = 0;
            // 
            // P2Name
            // 
            P2Name.AutoSize = true;
            P2Name.BackColor = SystemColors.ActiveCaptionText;
            P2Name.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            P2Name.ForeColor = Color.Red;
            P2Name.Location = new Point(126, 103);
            P2Name.Name = "P2Name";
            P2Name.Size = new Size(25, 23);
            P2Name.TabIndex = 23;
            P2Name.Text = ",,,";
            // 
            // P1Name
            // 
            P1Name.AutoSize = true;
            P1Name.BackColor = SystemColors.ActiveCaptionText;
            P1Name.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            P1Name.ForeColor = Color.Red;
            P1Name.Location = new Point(126, 57);
            P1Name.Name = "P1Name";
            P1Name.Size = new Size(25, 23);
            P1Name.TabIndex = 22;
            P1Name.Text = "...";
            // 
            // VSlabel
            // 
            VSlabel.AutoSize = true;
            VSlabel.BackColor = SystemColors.ActiveCaptionText;
            VSlabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            VSlabel.ForeColor = SystemColors.Control;
            VSlabel.Location = new Point(64, 80);
            VSlabel.Name = "VSlabel";
            VSlabel.Size = new Size(29, 23);
            VSlabel.TabIndex = 21;
            VSlabel.Text = "vs";
            // 
            // P2label
            // 
            P2label.AutoSize = true;
            P2label.BackColor = SystemColors.ActiveCaptionText;
            P2label.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            P2label.ForeColor = SystemColors.Control;
            P2label.Location = new Point(31, 103);
            P2label.Name = "P2label";
            P2label.Size = new Size(89, 23);
            P2label.TabIndex = 20;
            P2label.Text = "Player 2:";
            // 
            // P1label
            // 
            P1label.AutoSize = true;
            P1label.BackColor = SystemColors.ActiveCaptionText;
            P1label.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            P1label.ForeColor = SystemColors.Control;
            P1label.Location = new Point(31, 57);
            P1label.Name = "P1label";
            P1label.Size = new Size(89, 23);
            P1label.TabIndex = 19;
            P1label.Text = "Player 1:";
            P1label.Click += P1label_Click;
            // 
            // restart
            // 
            restart.AutoSize = true;
            restart.BackColor = Color.Red;
            restart.Cursor = Cursors.Hand;
            restart.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            restart.ForeColor = SystemColors.Control;
            restart.Location = new Point(109, 392);
            restart.Name = "restart";
            restart.Size = new Size(72, 23);
            restart.TabIndex = 18;
            restart.Text = "Restart";
            restart.Click += restart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(245, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // C3
            // 
            C3.BackColor = Color.Red;
            C3.Cursor = Cursors.Hand;
            C3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            C3.ForeColor = Color.Red;
            C3.Location = new Point(187, 299);
            C3.Name = "C3";
            C3.Size = new Size(72, 66);
            C3.TabIndex = 15;
            C3.UseVisualStyleBackColor = false;
            C3.Click += buttonClick;
            // 
            // C2
            // 
            C2.BackColor = Color.Red;
            C2.Cursor = Cursors.Hand;
            C2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            C2.ForeColor = Color.Red;
            C2.Location = new Point(109, 299);
            C2.Name = "C2";
            C2.Size = new Size(72, 66);
            C2.TabIndex = 14;
            C2.UseVisualStyleBackColor = false;
            C2.Click += buttonClick;
            // 
            // C1
            // 
            C1.BackColor = Color.Red;
            C1.Cursor = Cursors.Hand;
            C1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            C1.ForeColor = Color.Red;
            C1.Location = new Point(31, 299);
            C1.Name = "C1";
            C1.Size = new Size(72, 66);
            C1.TabIndex = 13;
            C1.UseVisualStyleBackColor = false;
            C1.Click += buttonClick;
            // 
            // B3
            // 
            B3.BackColor = Color.Red;
            B3.Cursor = Cursors.Hand;
            B3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            B3.ForeColor = Color.Red;
            B3.Location = new Point(187, 227);
            B3.Name = "B3";
            B3.Size = new Size(72, 66);
            B3.TabIndex = 12;
            B3.UseVisualStyleBackColor = false;
            B3.Click += buttonClick;
            // 
            // B2
            // 
            B2.BackColor = Color.Red;
            B2.Cursor = Cursors.Hand;
            B2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            B2.ForeColor = Color.Red;
            B2.Location = new Point(109, 227);
            B2.Name = "B2";
            B2.Size = new Size(72, 66);
            B2.TabIndex = 11;
            B2.UseVisualStyleBackColor = false;
            B2.Click += buttonClick;
            // 
            // B1
            // 
            B1.BackColor = Color.Red;
            B1.Cursor = Cursors.Hand;
            B1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            B1.ForeColor = Color.Red;
            B1.Location = new Point(31, 227);
            B1.Name = "B1";
            B1.Size = new Size(72, 66);
            B1.TabIndex = 10;
            B1.UseVisualStyleBackColor = false;
            B1.Click += buttonClick;
            // 
            // A3
            // 
            A3.BackColor = Color.Red;
            A3.Cursor = Cursors.Hand;
            A3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            A3.ForeColor = Color.Red;
            A3.Location = new Point(187, 155);
            A3.Name = "A3";
            A3.Size = new Size(72, 66);
            A3.TabIndex = 9;
            A3.UseVisualStyleBackColor = false;
            A3.Click += buttonClick;
            // 
            // A1
            // 
            A1.BackColor = Color.Red;
            A1.Cursor = Cursors.Hand;
            A1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            A1.ForeColor = Color.Red;
            A1.Location = new Point(31, 155);
            A1.Name = "A1";
            A1.Size = new Size(72, 66);
            A1.TabIndex = 8;
            A1.UseVisualStyleBackColor = false;
            A1.Click += buttonClick;
            // 
            // A2
            // 
            A2.BackColor = Color.Red;
            A2.Cursor = Cursors.Hand;
            A2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            A2.ForeColor = Color.Red;
            A2.Location = new Point(109, 155);
            A2.Name = "A2";
            A2.Size = new Size(72, 66);
            A2.TabIndex = 7;
            A2.UseVisualStyleBackColor = false;
            A2.Click += buttonClick;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(320, 495);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button C3;
        private Button C2;
        private Button C1;
        private Button B3;
        private Button B2;
        private Button B1;
        private Button A3;
        private Button A1;
        private Button A2;
        private PictureBox pictureBox1;
        private Label restart;
        private Label VSlabel;
        private Label P2label;
        private Label P1label;
        private Label P2Name;
        private Label P1Name;
    }
}