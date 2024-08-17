namespace ShapeSearch_kf
{
    partial class frmGame
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
            components = new System.ComponentModel.Container();
            lblTime = new Label();
            timerTime = new System.Windows.Forms.Timer(components);
            pbxShape1 = new PictureBox();
            lblFindShape = new Label();
            pbxShape2 = new PictureBox();
            pbxShape3 = new PictureBox();
            pbxShape4 = new PictureBox();
            pbxShape5 = new PictureBox();
            pbxShape7 = new PictureBox();
            pbxShape6 = new PictureBox();
            pbxShape8 = new PictureBox();
            pbxShape9 = new PictureBox();
            pbxShape10 = new PictureBox();
            pnlShapeHolder = new Panel();
            lblScore = new Label();
            lblScoreLabel = new Label();
            timerCountdown = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbxShape1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape10).BeginInit();
            pnlShapeHolder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Gill Sans Ultra Bold Condensed", 50F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(775, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(174, 137);
            lblTime.TabIndex = 0;
            lblTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // timerTime
            // 
            timerTime.Interval = 1000;
            timerTime.Tick += timerTime_Tick;
            // 
            // pbxShape1
            // 
            pbxShape1.Location = new Point(114, 263);
            pbxShape1.Name = "pbxShape1";
            pbxShape1.Size = new Size(250, 250);
            pbxShape1.TabIndex = 1;
            pbxShape1.TabStop = false;
            pbxShape1.Click += pbxShape1_Click;
            // 
            // lblFindShape
            // 
            lblFindShape.Font = new Font("Gill Sans Ultra Bold Condensed", 50F, FontStyle.Regular, GraphicsUnit.Point);
            lblFindShape.Location = new Point(115, 105);
            lblFindShape.Name = "lblFindShape";
            lblFindShape.Size = new Size(1494, 137);
            lblFindShape.TabIndex = 2;
            lblFindShape.TextAlign = ContentAlignment.TopCenter;
            lblFindShape.Click += lblFindShape_Click;
            // 
            // pbxShape2
            // 
            pbxShape2.Location = new Point(421, 263);
            pbxShape2.Name = "pbxShape2";
            pbxShape2.Size = new Size(250, 250);
            pbxShape2.TabIndex = 3;
            pbxShape2.TabStop = false;
            pbxShape2.Click += pbxShape2_Click;
            // 
            // pbxShape3
            // 
            pbxShape3.Location = new Point(735, 263);
            pbxShape3.Name = "pbxShape3";
            pbxShape3.Size = new Size(250, 250);
            pbxShape3.TabIndex = 4;
            pbxShape3.TabStop = false;
            pbxShape3.Click += pbxShape3_Click;
            // 
            // pbxShape4
            // 
            pbxShape4.Location = new Point(1049, 263);
            pbxShape4.Name = "pbxShape4";
            pbxShape4.Size = new Size(250, 250);
            pbxShape4.TabIndex = 5;
            pbxShape4.TabStop = false;
            pbxShape4.Click += pbxShape4_Click;
            // 
            // pbxShape5
            // 
            pbxShape5.Location = new Point(1358, 263);
            pbxShape5.Name = "pbxShape5";
            pbxShape5.Size = new Size(250, 250);
            pbxShape5.TabIndex = 6;
            pbxShape5.TabStop = false;
            pbxShape5.Click += pbxShape5_Click;
            // 
            // pbxShape7
            // 
            pbxShape7.Location = new Point(421, 566);
            pbxShape7.Name = "pbxShape7";
            pbxShape7.Size = new Size(250, 250);
            pbxShape7.TabIndex = 7;
            pbxShape7.TabStop = false;
            pbxShape7.Click += pbxShape7_Click;
            // 
            // pbxShape6
            // 
            pbxShape6.Location = new Point(114, 566);
            pbxShape6.Name = "pbxShape6";
            pbxShape6.Size = new Size(250, 250);
            pbxShape6.TabIndex = 8;
            pbxShape6.TabStop = false;
            pbxShape6.Click += pbxShape6_Click;
            // 
            // pbxShape8
            // 
            pbxShape8.Location = new Point(735, 566);
            pbxShape8.Name = "pbxShape8";
            pbxShape8.Size = new Size(250, 250);
            pbxShape8.TabIndex = 9;
            pbxShape8.TabStop = false;
            pbxShape8.Click += pbxShape8_Click;
            // 
            // pbxShape9
            // 
            pbxShape9.Location = new Point(1049, 566);
            pbxShape9.Name = "pbxShape9";
            pbxShape9.Size = new Size(250, 250);
            pbxShape9.TabIndex = 10;
            pbxShape9.TabStop = false;
            pbxShape9.Click += pbxShape9_Click;
            // 
            // pbxShape10
            // 
            pbxShape10.Location = new Point(1358, 566);
            pbxShape10.Name = "pbxShape10";
            pbxShape10.Size = new Size(250, 250);
            pbxShape10.TabIndex = 11;
            pbxShape10.TabStop = false;
            pbxShape10.Click += pbxShape10_Click;
            // 
            // pnlShapeHolder
            // 
            pnlShapeHolder.Controls.Add(lblFindShape);
            pnlShapeHolder.Controls.Add(lblTime);
            pnlShapeHolder.Controls.Add(lblScore);
            pnlShapeHolder.Controls.Add(lblScoreLabel);
            pnlShapeHolder.Location = new Point(-1, 4);
            pnlShapeHolder.Name = "pnlShapeHolder";
            pnlShapeHolder.Size = new Size(1691, 880);
            pnlShapeHolder.TabIndex = 12;
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Gill Sans Ultra Bold Condensed", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ImageAlign = ContentAlignment.TopRight;
            lblScore.Location = new Point(225, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(332, 94);
            lblScore.TabIndex = 4;
            lblScore.Text = "0";
            lblScore.Click += lblScore_Click;
            // 
            // lblScoreLabel
            // 
            lblScoreLabel.AutoSize = true;
            lblScoreLabel.Font = new Font("Gill Sans Ultra Bold Condensed", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblScoreLabel.Location = new Point(0, 0);
            lblScoreLabel.Name = "lblScoreLabel";
            lblScoreLabel.Size = new Size(249, 94);
            lblScoreLabel.TabIndex = 5;
            lblScoreLabel.Text = "SCORE:";
            // 
            // timerCountdown
            // 
            timerCountdown.Enabled = true;
            timerCountdown.Interval = 1000;
            timerCountdown.Tick += timerCountdown_Tick;
            // 
            // frmGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1688, 884);
            Controls.Add(pbxShape10);
            Controls.Add(pbxShape9);
            Controls.Add(pbxShape8);
            Controls.Add(pbxShape6);
            Controls.Add(pbxShape7);
            Controls.Add(pbxShape5);
            Controls.Add(pbxShape4);
            Controls.Add(pbxShape2);
            Controls.Add(pbxShape1);
            Controls.Add(pbxShape3);
            Controls.Add(pnlShapeHolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += frmGame_Load;
            ((System.ComponentModel.ISupportInitialize)pbxShape1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShape10).EndInit();
            pnlShapeHolder.ResumeLayout(false);
            pnlShapeHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTime;
        private System.Windows.Forms.Timer timerTime;
        private PictureBox pbxShape1;
        private Label lblFindShape;
        private PictureBox pbxShape2;
        private PictureBox pbxShape3;
        private PictureBox pbxShape4;
        private PictureBox pbxShape5;
        private PictureBox pbxShape7;
        private PictureBox pbxShape6;
        private PictureBox pbxShape8;
        private PictureBox pbxShape9;
        private PictureBox pbxShape10;
        private Panel pnlShapeHolder;
        private System.Windows.Forms.Timer timerCountdown;
        private Label lblScore;
        private Label lblScoreLabel;
    }
}