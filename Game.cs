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
            int score = 0;

            RandomizeImages();

           
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            
        }

        private void RandomizeImages()
        {
            string filePath =  @"C:\Users\kaela\OneDrive - Bayfield High School\2024\comp sci\programming\shape search game\ShapeSearch_kf\shapes";

            //sorts files named in the format colour_shape into an array called images
            string[] images = Directory.GetFiles(filePath, "*_*.png*");

            //method to shuffle the images array
            ShuffleImages(images);

            //gets 10 images at random from all images and creates a list
            List<string> chosenImages = images.Take(10).ToList();


            
            //for the 10 images added to the list
            for (int i = 0; i < 10; i++)
            {
                
            }

        }
        private void ShuffleImages (string[] images)
        {
            //random image
            Random random = new Random();
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
