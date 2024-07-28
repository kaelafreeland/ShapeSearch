using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeSearch_kf
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
            RandomizeImages();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            
        }

        private void RandomizeImages()
        {
            string filePath = "C:\Users\kaela\OneDrive - Bayfield High School\2024\comp sci\programming\shape search game\ShapeSearch_kf\shapes";//how do i get right path
            string[] images = Directory.GetFiles(filePath, "*_*.png*");
            //random image
            Random random = new Random();

            //for 10 images in 
            for (int i = 0; i < 10; i++)



        }

        public void timerTime_Tick(object sender, EventArgs e)
        {
            //convert current timer value to an int
            int timer = Convert.ToInt32(lblTime.Text);
            //increment timer value by -1
            timer = timer - 1;
            //convert timer value to string and write to label
            lblTime.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                this.Hide();
                //creates and opens game screen and makes form variable to address throughout code
                frmEnd frmEnd = new frmEnd();
                //opens game form
                frmEnd.Show();
            }
        }

        private void pbxShape4_Click(object sender, EventArgs e)
        {

        }

        private void pbxShape5_Click(object sender, EventArgs e)
        {

        }

        private void pbxShape9_Click(object sender, EventArgs e)
        {

        }
    }
}
