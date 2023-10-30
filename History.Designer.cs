namespace TicTacToe
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            panel1 = new Panel();
            PvPdgv = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            PvAIdgv = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            exitHistoryButton = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PvPdgv).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PvAIdgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitHistoryButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(PvPdgv);
            panel1.Location = new Point(12, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 165);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // PvPdgv
            // 
            PvPdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PvPdgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            PvPdgv.BackgroundColor = Color.Red;
            PvPdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PvPdgv.Location = new Point(14, 15);
            PvPdgv.Name = "PvPdgv";
            PvPdgv.RowTemplate.Height = 25;
            PvPdgv.Size = new Size(747, 135);
            PvPdgv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Franklin Gothic Heavy", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 81);
            label1.TabIndex = 1;
            label1.Text = "History";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(PvAIdgv);
            panel2.Location = new Point(12, 366);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 165);
            panel2.TabIndex = 2;
            // 
            // PvAIdgv
            // 
            PvAIdgv.AllowUserToAddRows = false;
            PvAIdgv.AllowUserToDeleteRows = false;
            PvAIdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PvAIdgv.BackgroundColor = Color.Red;
            PvAIdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PvAIdgv.GridColor = Color.Red;
            PvAIdgv.Location = new Point(14, 15);
            PvAIdgv.Name = "PvAIdgv";
            PvAIdgv.RowTemplate.Height = 25;
            PvAIdgv.Size = new Size(747, 135);
            PvAIdgv.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Franklin Gothic Heavy", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(317, 326);
            label2.Name = "label2";
            label2.Size = new Size(171, 37);
            label2.TabIndex = 3;
            label2.Text = "Player vs AI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Franklin Gothic Heavy", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(300, 118);
            label3.Name = "label3";
            label3.Size = new Size(228, 37);
            label3.TabIndex = 4;
            label3.Text = "Player vs Player";
            // 
            // exitHistoryButton
            // 
            exitHistoryButton.BackColor = Color.Red;
            exitHistoryButton.Cursor = Cursors.Hand;
            exitHistoryButton.Image = (Image)resources.GetObject("exitHistoryButton.Image");
            exitHistoryButton.Location = new Point(749, 3);
            exitHistoryButton.Name = "exitHistoryButton";
            exitHistoryButton.Size = new Size(69, 27);
            exitHistoryButton.SizeMode = PictureBoxSizeMode.Zoom;
            exitHistoryButton.TabIndex = 5;
            exitHistoryButton.TabStop = false;
            exitHistoryButton.Click += exitHistoryButton_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 543);
            Controls.Add(exitHistoryButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PvPdgv).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PvAIdgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitHistoryButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView PvPdgv;
        private DataGridView PvAIdgv;
        private Label label2;
        private Label label3;
        private PictureBox exitHistoryButton;
    }
}