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
            pbxShapesColours = new PictureBox();
            tbxInstructions = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShapesColours).BeginInit();
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
            // pbxShapesColours
            // 
            pbxShapesColours.Image = (Image)resources.GetObject("pbxShapesColours.Image");
            pbxShapesColours.Location = new Point(402, 266);
            pbxShapesColours.Name = "pbxShapesColours";
            pbxShapesColours.Size = new Size(900, 488);
            pbxShapesColours.TabIndex = 6;
            pbxShapesColours.TabStop = false;
            // 
            // tbxInstructions
            // 
            tbxInstructions.Font = new Font("Gill Sans Ultra Bold Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbxInstructions.Location = new Point(363, 161);
            tbxInstructions.Multiline = true;
            tbxInstructions.Name = "tbxInstructions";
            tbxInstructions.Size = new Size(977, 120);
            tbxInstructions.TabIndex = 7;
            tbxInstructions.Text = "Click on the coloured shape at the top of the screen to score points! But be careful if you click the wrong shape you'lll lose points.";
            // 
            // frmHowToPlay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1688, 884);
            Controls.Add(pbxShapesColours);
            Controls.Add(btnBackToStart);
            Controls.Add(pbxPanel2);
            Controls.Add(pbxPanel1);
            Controls.Add(tbxInstructions);
            Controls.Add(lblHowToPlay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHowToPlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += frmHowToPlay_Load;
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShapesColours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxPanel1;
        private PictureBox pbxPanel2;
        private Button btnBackToStart;
        private Label lblHowToPlay;
        private PictureBox pbxShapesColours;
        private TextBox tbxInstructions;
    }
}