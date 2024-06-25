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
            // frmEnd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1688, 884);
            Controls.Add(pbxPanel2);
            Controls.Add(pbxPanel1);
            Name = "frmEnd";
            Text = "End";
            ((System.ComponentModel.ISupportInitialize)pbxPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPanel2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxPanel1;
        private PictureBox pbxPanel2;
    }
}