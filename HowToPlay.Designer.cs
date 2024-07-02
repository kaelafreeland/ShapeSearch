namespace ShapeSearch_kf
{
    partial class frmHowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHowToPlay));
            pbxPanel1 = new PictureBox();
            pbxPanel2 = new PictureBox();
            btnBackToStart = new Button();
            lblHowToPlay = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbxPanel1
            // 
            pbxPanel1.Image = (Image)resources.GetObject("pbxPanel1.Image");
            pbxPanel1.Location = new Point(-1, 0);
            pbxPanel1.Name = "pbxPanel1";
            pbxPanel1.Size = new Size(281, 884);
            pbxPanel1.TabIndex = 1;
            pbxPanel1.TabStop = false;
            // 
            // pbxPanel2
            // 
            pbxPanel2.Image = (Image)resources.GetObject("pbxPanel2.Image");
            pbxPanel2.Location = new Point(1411, 0);
            pbxPanel2.Name = "pbxPanel2";
            pbxPanel2.Size = new Size(281, 884);
            pbxPanel2.TabIndex = 2;
            pbxPanel2.TabStop = false;
            // 
            // btnBackToStart
            // 
            btnBackToStart.BackColor = Color.YellowGreen;
            btnBackToStart.Font = new Font("Gill Sans Ultra Bold Condensed", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackToStart.Location = new Point(520, 760);
            btnBackToStart.Name = "btnBackToStart";
            btnBackToStart.Size = new Size(672, 112);
            btnBackToStart.TabIndex = 4;
            btnBackToStart.Text = "BACK TO START";
            btnBackToStart.UseVisualStyleBackColor = false;
            btnBackToStart.Click += btnBackToStart_Click;
            // 
            // lblHowToPlay
            // 
            lblHowToPlay.AutoSize = true;
            lblHowToPlay.Font = new Font("Gill Sans Ultra Bold Condensed", 80F, FontStyle.Regular, GraphicsUnit.Point);
            lblHowToPlay.ForeColor = Color.SteelBlue;
            lblHowToPlay.Location = new Point(305, -22);
            lblHowToPlay.Name = "lblHowToPlay";
            lblHowToPlay.Size = new Size(1074, 217);
            lblHowToPlay.TabIndex = 5;
            lblHowToPlay.Text = "HOW TO PLAY";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(416, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(900, 492);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmHowToPlay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1688, 884);
            Controls.Add(pictureBox1);
            Controls.Add(lblHowToPlay);
            Controls.Add(btnBackToStart);
            Controls.Add(pbxPanel2);
            Controls.Add(pbxPanel1);
            Name = "frmHowToPlay";
            Text = "HowToPlay";
            Load += frmHowToPlay_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxPanel1;
        private PictureBox pbxPanel2;
        private Button btnBackToStart;
        private Label lblHowToPlay;
        private PictureBox pictureBox1;
    }
}