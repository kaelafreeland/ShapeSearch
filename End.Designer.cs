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
            lblWellDone = new Label();
            lblPoints = new Label();
            tbxEnterName = new TextBox();
            tbxEnding = new TextBox();
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
            // lblWellDone
            // 
            lblWellDone.AutoSize = true;
            lblWellDone.Font = new Font("Gill Sans Ultra Bold Condensed", 70F, FontStyle.Regular, GraphicsUnit.Point);
            lblWellDone.ForeColor = Color.SteelBlue;
            lblWellDone.Location = new Point(411, 63);
            lblWellDone.Name = "lblWellDone";
            lblWellDone.Size = new Size(841, 190);
            lblWellDone.TabIndex = 5;
            lblWellDone.Text = "WELL DONE!!";
            // 
            // lblPoints
            // 
            lblPoints.Font = new Font("Gill Sans Ultra Bold Condensed", 50F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoints.ForeColor = Color.FromArgb(109, 88, 157);
            lblPoints.Location = new Point(287, 253);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(1113, 137);
            lblPoints.TabIndex = 6;
            lblPoints.TextAlign = ContentAlignment.TopCenter;
            lblPoints.Click += lblPoints_Click;
            // 
            // tbxEnterName
            // 
            tbxEnterName.BackColor = Color.FromArgb(255, 209, 71);
            tbxEnterName.Font = new Font("Gill Sans Ultra Bold Condensed", 40F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEnterName.Location = new Point(325, 625);
            tbxEnterName.MaxLength = 16;
            tbxEnterName.Name = "tbxEnterName";
            tbxEnterName.Size = new Size(1029, 107);
            tbxEnterName.TabIndex = 7;
            tbxEnterName.Text = " ENTER NAME HERE...";
            tbxEnterName.Click += tbxEnterName_Click;
            tbxEnterName.TextChanged += tbxEnterName_TextChanged;
            tbxEnterName.Enter += tbxEnterName_Enter;
            tbxEnterName.KeyDown += tbxName_KeyDown;
            tbxEnterName.Leave += tbxEnterName_Leave;
            // 
            // tbxEnding
            // 
            tbxEnding.Font = new Font("Gill Sans Ultra Bold Condensed", 30F, FontStyle.Regular, GraphicsUnit.Point);
            tbxEnding.Location = new Point(325, 437);
            tbxEnding.Multiline = true;
            tbxEnding.Name = "tbxEnding";
            tbxEnding.Size = new Size(1029, 207);
            tbxEnding.TabIndex = 8;
            tbxEnding.Text = "TO MAKE THE LEADERBOARAD ENTER YOUR NAME BELOW (16 char limit):\r\n";
            // 
            // frmEnd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1688, 884);
            Controls.Add(pbxPanel2);
            Controls.Add(pbxPanel1);
            Controls.Add(tbxEnterName);
            Controls.Add(lblPoints);
            Controls.Add(lblWellDone);
            Controls.Add(tbxEnding);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEnd";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label lblWellDone;
        private Label lblPoints;
        private TextBox tbxEnterName;
        private TextBox tbxEnding;
    }
}