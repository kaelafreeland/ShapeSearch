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
            btnBackToStart.Font = new Font("Gill Sans Ultra Bold Condensed", 60F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackToStart.Location = new Point(386, 710);
            btnBackToStart.Name = "btnBackToStart";
            btnBackToStart.Size = new Size(913, 162);
            btnBackToStart.TabIndex = 3;
            btnBackToStart.Text = "BACK TO START";
            btnBackToStart.UseVisualStyleBackColor = false;
            btnBackToStart.Click += btnBackToStart_Click;
            // 
            // frmLeaderboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1688, 884);
            Controls.Add(btnBackToStart);
            Controls.Add(pbxPanel1);
            Controls.Add(pbxPanel2);
            Controls.Add(lblLeaderBoard);
            Name = "frmLeaderboard";
            Text = "Leaderboard";
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
    }
}