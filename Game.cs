using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ShapeSearch_kf
{
    public partial class frmGame : Form
    {
        private PictureBox[] pictureBoxes;

        public frmGame()
        {
            InitializeComponent();
            int score = 0;
            InitializePbxShapes();
            RandomizeImages();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializePbxShapes()
        {
            pictureBoxes = new PictureBox[10];

            pictureBoxes[0] = pbxShape1;
            pictureBoxes[1] = pbxShape2;
            pictureBoxes[2] = pbxShape3;
            pictureBoxes[3] = pbxShape4;
            pictureBoxes[4] = pbxShape5;
            pictureBoxes[5] = pbxShape6;
            pictureBoxes[6] = pbxShape7;
            pictureBoxes[7] = pbxShape8;
            pictureBoxes[8] = pbxShape9;
            pictureBoxes[9] = pbxShape10;
        }

        private void RandomizeImages()
        {
            string filePath = @"C:\Users\kaela\OneDrive - Bayfield High School\2024\comp sci\programming\shape search game\ShapeSearch_kf\shapes";

            //sort files named in the format colour_shape into an array called images
            string[] images = Directory.GetFiles(filePath, "*_*.png");


            //method to shuffle array of images
            ShuffleImages(images);

            //gets 10 images at random from all images and creates a list
            List<string> chosenImages = images.Take(10).ToList();

            //for the 10 images added to the list
            for (int i = 0; i < 10; i++)
            {
                //if pictureboxes are not empty
                if (pictureBoxes[i] != null)
                {
                    //put 1 of 10 images into empty picturebox until all are full
                    pictureBoxes[i].Image = Image.FromFile(chosenImages[i]);
                    
                }
            }
        }

        private void ShuffleImages(string[] images)
        {
            // Random image
            Random random = new Random();


            //loops through images array from end to start
            for (int i = images.Length - 1; i > 0; i--)
            {
                //gets index from 0 to current index
                int r = random.Next(0, i + 1);
                
                //swap images from current to new index (r)
                string placeholder = images[i];
                //moves random image to index and current image to random index
                images[i] = images[r];
                images[r] = placeholder;
            }
        }

        public void timerTime_Tick(object sender, EventArgs e)
        {
            // Convert current timer value to an int
            int timer = Convert.ToInt32(lblTime.Text);
            // Increment timer value by -1
            timer = timer - 1;
            // Convert timer value to string and write to label
            lblTime.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                this.Hide();
                // Creates and opens game screen and makes form variable to address throughout code
                frmEnd frmEnd = new frmEnd();
                // Opens game form
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
