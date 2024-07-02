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
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Gill Sans Ultra Bold Condensed", 50F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(735, -9);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(174, 137);
            lblTime.TabIndex = 0;
            lblTime.Text = "30";
            // 
            // timerTime
            // 
            timerTime.Interval = 1;
            // 
            // frmGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1688, 884);
            Controls.Add(lblTime);
            Name = "frmGame";
            Text = "Game";
            Load += frmGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private System.Windows.Forms.Timer timerTime;
    }
}