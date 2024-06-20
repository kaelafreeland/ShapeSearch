namespace ShapeSearch_kf
{
    partial class StartScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            lblShapeSearch = new Label();
            btnStart = new Button();
            btnHowToPlay = new Button();
            btnLeaderboard = new Button();
            pbxPanel2 = new PictureBox();
            pbxPanel1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).BeginInit();
            SuspendLayout();
            // 
            // lblShapeSearch
            // 
            lblShapeSearch.AutoSize = true;
            lblShapeSearch.Font = new Font("Gill Sans Ultra Bold Condensed", 80F, FontStyle.Regular, GraphicsUnit.Point);
            lblShapeSearch.ForeColor = Color.SteelBlue;
            lblShapeSearch.Location = new Point(274, 90);
            lblShapeSearch.Name = "lblShapeSearch";
            lblShapeSearch.Size = new Size(1160, 217);
            lblShapeSearch.TabIndex = 0;
            lblShapeSearch.Text = "SHAPE SEARCH";
            lblShapeSearch.Click += lblShapeSearch_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(255, 209, 71);
            btnStart.Font = new Font("Gill Sans Ultra Bold Condensed", 90F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(444, 310);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(768, 223);
            btnStart.TabIndex = 1;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnHowToPlay
            // 
            btnHowToPlay.BackColor = Color.YellowGreen;
            btnHowToPlay.Font = new Font("Gill Sans Ultra Bold Condensed", 45F, FontStyle.Bold, GraphicsUnit.Point);
            btnHowToPlay.Location = new Point(444, 571);
            btnHowToPlay.Name = "btnHowToPlay";
            btnHowToPlay.Size = new Size(768, 112);
            btnHowToPlay.TabIndex = 2;
            btnHowToPlay.Text = "HOW TO PLAY";
            btnHowToPlay.UseVisualStyleBackColor = false;
            btnHowToPlay.Click += btnHowToPlay_Click;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.BackColor = Color.YellowGreen;
            btnLeaderboard.Font = new Font("Gill Sans Ultra Bold Condensed", 45F, FontStyle.Bold, GraphicsUnit.Point);
            btnLeaderboard.ForeColor = Color.Black;
            btnLeaderboard.Location = new Point(444, 689);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(768, 121);
            btnLeaderboard.TabIndex = 3;
            btnLeaderboard.Text = "LEADERBOARD";
            btnLeaderboard.UseVisualStyleBackColor = false;
            btnLeaderboard.Click += btnLeaderboard_Click;
            // 
            // pbxPanel2
            // 
            pbxPanel2.Image = (Image)resources.GetObject("pbxPanel2.Image");
            pbxPanel2.Location = new Point(1407, 0);
            pbxPanel2.Name = "pbxPanel2";
            pbxPanel2.Size = new Size(281, 884);
            pbxPanel2.TabIndex = 4;
            pbxPanel2.TabStop = false;
            // 
            // pbxPanel1
            // 
            pbxPanel1.Image = (Image)resources.GetObject("pbxPanel1.Image");
            pbxPanel1.Location = new Point(0, 0);
            pbxPanel1.Name = "pbxPanel1";
            pbxPanel1.Size = new Size(281, 884);
            pbxPanel1.TabIndex = 5;
            pbxPanel1.TabStop = false;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1688, 884);
            Controls.Add(pbxPanel1);
            Controls.Add(pbxPanel2);
            Controls.Add(btnLeaderboard);
            Controls.Add(btnHowToPlay);
            Controls.Add(btnStart);
            Controls.Add(lblShapeSearch);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StartScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartScreen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShapeSearch;
        private Button btnStart;
        private Button btnHowToPlay;
        private Button btnLeaderboard;
        private PictureBox pbxPanel2;
        private PictureBox pbxPanel1;
    }
}