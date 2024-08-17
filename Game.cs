using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace ShapeSearch_kf
{
    public partial class frmGame : Form
    {
        private PictureBox[] pictureBoxes;
        private string specificShape;
        int score = 0;
        int addpoints = 10;
        int removepoints = 3;

        int gameCountdown = 5;
        int gameTimer = 30;

        public frmGame()
        {
            InitializeComponent();
            InitializePbxShapes();
            RandomizeImages();

        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            DisableShapes();
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

        private void DisableShapes()
        {
            //disables all picture boxes so they cannot be clicked
            foreach (PictureBox pbx in pictureBoxes)
            {
                pbx.Enabled = false;
            }
        }

        private void EnableShapes()
        {
            //enables all picture boxes so they can be clicked
            foreach (PictureBox pbx in pictureBoxes)
            {
                pbx.Enabled = true;
            }
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
                    pictureBoxes[i].Image = System.Drawing.Image.FromFile(chosenImages[i]);
                    pictureBoxes[i].Tag = chosenImages[i];
                }
            }

            SpecificShape(chosenImages);
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

        private void SpecificShape(List<string> chosenImages)
        {
            Random random = new Random();

            specificShape = chosenImages[random.Next(chosenImages.Count)];

            string file = Path.GetFileNameWithoutExtension(specificShape);

            //creates data array to spplit file name into colour and shape 
            string[] data = file.Split('_');
            string colour = data[0];
            string shape = data[1];

            //writes the name of the chosen shape onto the form
            lblFindShape.Text = "CLICK THE " + colour.ToUpper() + " " + shape.ToUpper();

        }



        private void ShapeClicked(string specificShape, PictureBox clickedPictureBox)
        {
            if (clickedPictureBox.Tag.ToString() == specificShape)
            {
                score = score += addpoints;
                RandomizeImages();
                lblScore.Text = score.ToString();
            }
            else
            {

                score = score -= removepoints;
                lblScore.Text = score.ToString();
            }
        }


        private void timerCountdown_Tick(object sender, EventArgs e)
        {

            lblTime.Text = gameCountdown.ToString();
            gameCountdown--;

            //when countdown reaches 0
            if (gameCountdown < 0)
            {
                //stop countdown 
                timerCountdown.Stop(); 
                //allow for shapes to be clicked
                EnableShapes();  
                gameCountdown = 0;
                lblTime.Text = gameCountdown.ToString();
                //start the game timer
                timerTime.Start();
            }

        }

        public void timerTime_Tick(object sender, EventArgs e)
        {
            gameTimer--;
            lblTime.Text = gameCountdown.ToString();

            //if the timer = 0
            if (gameCountdown == 0)
            {
                //end the game and close current form
                timerTime.Stop();
                this.Hide();


                List<int> mockLeaderboard = leaderboardData();

                //creat end form and open it
                frmEnd frmEnd = new frmEnd(score);
                frmEnd.Show();
            }
        }

        private List<int> leaderboardData()
        {
            //returns new list
            return new List<int>();
        }
        #region pbxShapes

        private void pbxShape1_Click(object sender, EventArgs e)
        {
            ShapeClicked(specificShape, pbxShape1);
        }

        private void pbxShape2_Click(object sender, EventArgs e)
        {
            ShapeClicked(specificShape, pbxShape2);
        }

        private void pbxShape3_Click(object sender, EventArgs e)
        {
            ShapeClicked(specificShape, pbxShape3);
        }

        private void pbxShape4_Click(object sender, EventArgs e)
        {
            ShapeClicked(specificShape, pbxShape4);
        }

        private void pbxShape5_Click(object sender, EventArgs e)
        {
            ShapeClicked(specificShape, pbxShape5);
        }

        private void pbxShape6_Click(object sender, EventArgs e)
        {
            ShapeClicked(specificShape, pbxShape6);
        }

        private void pbxShape7_Click(object sender, EventArgs e)
        {
            ShapeClicked(specificShape, pbxShape7);
        }

        private void pbxShape8_Click(object sender, EventArgs e)
        {
            ShapeClicked(specificShape, pbxShape8);

        }

        private void pbxShape9_Click(object sender, EventArgs e)
        {
            ShapeClicked(specificShape, pbxShape9);
        }
        private void pbxShape10_Click(object sender, EventArgs e)
        {
            ShapeClicked(specificShape, pbxShape10);
        }

        #endregion


        private void lblCountdown_Click(object sender, EventArgs e)
        {

        }

        private void lblFindShape_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

       
    }
}
