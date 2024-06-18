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
            lblShapeSearch = new Label();
            btnStart = new Button();
            btnHowToPlay = new Button();
            btnLeaderboard = new Button();
            SuspendLayout();
            // 
            // lblShapeSearch
            // 
            lblShapeSearch.AutoSize = true;
            lblShapeSearch.Font = new Font("Microsoft Sans Serif", 50F, FontStyle.Bold, GraphicsUnit.Point);
            lblShapeSearch.ForeColor = Color.SteelBlue;
            lblShapeSearch.Location = new Point(300, 152);
            lblShapeSearch.Name = "lblShapeSearch";
            lblShapeSearch.Size = new Size(844, 113);
            lblShapeSearch.TabIndex = 0;
            lblShapeSearch.Text = "SHAPE SEARCH";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(255, 209, 71);
            btnStart.Font = new Font("Microsoft Sans Serif", 90F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(341, 326);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(768, 223);
            btnStart.TabIndex = 1;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnHowToPlay
            // 
            btnHowToPlay.BackColor = Color.YellowGreen;
            btnHowToPlay.Font = new Font("Microsoft Sans Serif", 45F, FontStyle.Bold, GraphicsUnit.Point);
            btnHowToPlay.Location = new Point(341, 555);
            btnHowToPlay.Name = "btnHowToPlay";
            btnHowToPlay.Size = new Size(768, 112);
            btnHowToPlay.TabIndex = 2;
            btnHowToPlay.Text = "HOW TO PLAY";
            btnHowToPlay.UseVisualStyleBackColor = false;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.BackColor = Color.YellowGreen;
            btnLeaderboard.Font = new Font("Microsoft Sans Serif", 45F, FontStyle.Bold, GraphicsUnit.Point);
            btnLeaderboard.ForeColor = Color.Black;
            btnLeaderboard.Location = new Point(341, 673);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(768, 121);
            btnLeaderboard.TabIndex = 3;
            btnLeaderboard.Text = "LEADERBOARD";
            btnLeaderboard.UseVisualStyleBackColor = false;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1478, 844);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShapeSearch;
        private Button btnStart;
        private Button btnHowToPlay;
        private Button btnLeaderboard;
    }
}