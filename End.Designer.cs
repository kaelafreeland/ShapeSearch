namespace ShapeSearch_kf
{
    partial class frmEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnd));
            pbxPanel1 = new PictureBox();
            pbxPanel2 = new PictureBox();
            btnToLeaderboard = new Button();
            lblWellDone = new Label();
            lblPoints = new Label();
            tbxEnterName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).BeginInit();
            SuspendLayout();
            // 
            // pbxPanel1
            // 
            pbxPanel1.Image = (Image)resources.GetObject("pbxPanel1.Image");
            pbxPanel1.Location = new Point(0, 0);
            pbxPanel1.Name = "pbxPanel1";
            pbxPanel1.Size = new Size(281, 884);
            pbxPanel1.TabIndex = 1;
            pbxPanel1.TabStop = false;
            // 
            // pbxPanel2
            // 
            pbxPanel2.Image = (Image)resources.GetObject("pbxPanel2.Image");
            pbxPanel2.Location = new Point(1406, 0);
            pbxPanel2.Name = "pbxPanel2";
            pbxPanel2.Size = new Size(281, 884);
            pbxPanel2.TabIndex = 2;
            pbxPanel2.TabStop = false;
            // 
            // btnToLeaderboard
            // 
            btnToLeaderboard.BackColor = Color.FromArgb(255, 209, 71);
            btnToLeaderboard.Font = new Font("Gill Sans Ultra Bold Condensed", 60F, FontStyle.Regular, GraphicsUnit.Point);
            btnToLeaderboard.Location = new Point(325, 714);
            btnToLeaderboard.Name = "btnToLeaderboard";
            btnToLeaderboard.Size = new Size(1029, 148);
            btnToLeaderboard.TabIndex = 3;
            btnToLeaderboard.Text = "TO LEADERBOARD";
            btnToLeaderboard.UseVisualStyleBackColor = false;
            btnToLeaderboard.Click += btnToLeaderboard_Click;
            // 
            // lblWellDone
            // 
            lblWellDone.AutoSize = true;
            lblWellDone.Font = new Font("Gill Sans Ultra Bold Condensed", 70F, FontStyle.Regular, GraphicsUnit.Point);
            lblWellDone.ForeColor = Color.SteelBlue;
            lblWellDone.Location = new Point(407, 9);
            lblWellDone.Name = "lblWellDone";
            lblWellDone.Size = new Size(841, 190);
            lblWellDone.TabIndex = 5;
            lblWellDone.Text = "WELL DONE!!";
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Font = new Font("Gill Sans Ultra Bold Condensed", 50F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoints.ForeColor = Color.FromArgb(109, 88, 157);
            lblPoints.Location = new Point(287, 164);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(1018, 137);
            lblPoints.TabIndex = 6;
            lblPoints.Text = "YOU SCORED # POINTS";
            // 
            // tbxEnterName
            // 
            tbxEnterName.BackColor = Color.FromArgb(255, 209, 71);
            tbxEnterName.Font = new Font("Gill Sans Ultra Bold Condensed", 40F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEnterName.Location = new Point(325, 601);
            tbxEnterName.MaxLength = 16;
            tbxEnterName.Name = "tbxEnterName";
            tbxEnterName.Size = new Size(1029, 107);
            tbxEnterName.TabIndex = 7;
            tbxEnterName.TextChanged += tbxEnterName_TextChanged;
            tbxEnterName.Enter += tbxEnterName_Enter;
            // 
            // frmEnd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1688, 884);
            Controls.Add(tbxEnterName);
            Controls.Add(lblPoints);
            Controls.Add(lblWellDone);
            Controls.Add(btnToLeaderboard);
            Controls.Add(pbxPanel2);
            Controls.Add(pbxPanel1);
            Name = "frmEnd";
            Text = "End";
            Load += frmEnd_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxPanel1;
        private PictureBox pbxPanel2;
        private Button btnToLeaderboard;
        private Label lblWellDone;
        private Label lblPoints;
        private TextBox tbxEnterName;
    }
}