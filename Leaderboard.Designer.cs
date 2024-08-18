namespace ShapeSearch_kf
{
    partial class frmLeaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaderboard));
            pbxPanel2 = new PictureBox();
            pbxPanel1 = new PictureBox();
            lblLeaderBoard = new Label();
            btnBackToStart = new Button();
            lblRank = new Label();
            lblScoreboard = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).BeginInit();
            SuspendLayout();
            // 
            // pbxPanel2
            // 
            pbxPanel2.Image = (Image)resources.GetObject("pbxPanel2.Image");
            pbxPanel2.Location = new Point(1405, 0);
            pbxPanel2.Name = "pbxPanel2";
            pbxPanel2.Size = new Size(281, 884);
            pbxPanel2.TabIndex = 0;
            pbxPanel2.TabStop = false;
            // 
            // pbxPanel1
            // 
            pbxPanel1.Image = (Image)resources.GetObject("pbxPanel1.Image");
            pbxPanel1.Location = new Point(-3, 0);
            pbxPanel1.Name = "pbxPanel1";
            pbxPanel1.Size = new Size(281, 884);
            pbxPanel1.TabIndex = 1;
            pbxPanel1.TabStop = false;
            // 
            // lblLeaderBoard
            // 
            lblLeaderBoard.AutoSize = true;
            lblLeaderBoard.Font = new Font("Gill Sans Ultra Bold Condensed", 80F, FontStyle.Regular, GraphicsUnit.Point);
            lblLeaderBoard.ForeColor = Color.SteelBlue;
            lblLeaderBoard.Location = new Point(285, 0);
            lblLeaderBoard.Name = "lblLeaderBoard";
            lblLeaderBoard.Size = new Size(1114, 217);
            lblLeaderBoard.TabIndex = 2;
            lblLeaderBoard.Text = "LEADERBOARD";
            lblLeaderBoard.Click += lblLeaderBoard_Click;
            // 
            // btnBackToStart
            // 
            btnBackToStart.BackColor = Color.YellowGreen;
            btnBackToStart.Font = new Font("Gill Sans Ultra Bold Condensed", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackToStart.Location = new Point(518, 760);
            btnBackToStart.Name = "btnBackToStart";
            btnBackToStart.Size = new Size(672, 112);
            btnBackToStart.TabIndex = 3;
            btnBackToStart.Text = "BACK TO START";
            btnBackToStart.UseVisualStyleBackColor = false;
            btnBackToStart.Click += btnBackToStart_Click;
            // 
            // lblRank
            // 
            lblRank.Font = new Font("Gill Sans Ultra Bold Condensed", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblRank.Location = new Point(397, 176);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(877, 66);
            lblRank.TabIndex = 5;
            lblRank.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblScoreboard
            // 
            lblScoreboard.Font = new Font("Gill Sans Ultra Bold Condensed", 34F, FontStyle.Regular, GraphicsUnit.Point);
            lblScoreboard.Location = new Point(441, 251);
            lblScoreboard.Name = "lblScoreboard";
            lblScoreboard.Size = new Size(977, 475);
            lblScoreboard.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold Condensed", 34F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(285, 251);
            label1.Name = "label1";
            label1.Size = new Size(173, 465);
            label1.TabIndex = 7;
            label1.Text = "1st-\r\n2nd-\r\n3rd-\r\n4th-\r\n5th-";
            // 
            // frmLeaderboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1688, 884);
            Controls.Add(lblScoreboard);
            Controls.Add(label1);
            Controls.Add(lblRank);
            Controls.Add(btnBackToStart);
            Controls.Add(pbxPanel1);
            Controls.Add(pbxPanel2);
            Controls.Add(lblLeaderBoard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLeaderboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leaderboard";
            Load += frmLeaderboard_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxPanel2;
        private PictureBox pbxPanel1;
        private Label lblLeaderBoard;
        private Button btnBackToStart;
        private Label lblRank;
        private Label lblScoreboard;
        private Label label1;
    }
}