using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShapeSearch_kf
{
    public partial class frmEnd : Form
    {
        int totalScore;

        bool textEntered = false;
        string username;

        //mock up list of actual leaderboard
        List<int> mockLeaderboard; 
        int rank;

        public frmEnd(int argstotalScore, List<int> argsmockLeaderboard)
        {
            InitializeComponent();
            totalScore = argstotalScore;

            mockLeaderboard = argsmockLeaderboard;
        }

        private void frmEnd_Load(object sender, EventArgs e)
        {
            lblPoints.Text = "YOU SCORED " + totalScore.ToString() + " POINTS";
            tbxEnterName.Text = " ENTER NAME HERE...";

            rank = CalculateRank(totalScore);
            lblRank.Text = "YOUR RANK: " + rank.ToString();
        }

        private int CalculateRank(int score)
        {
            //adds current score to leaderboard list
            mockLeaderboard.Add(score);

            //sorts the list of scores and orders it in descending order
            mockLeaderboard.Sort();
            mockLeaderboard.Reverse();

            //returns index of score +1
            return mockLeaderboard.IndexOf(score) + 1;
        }

        private void tbxEnterName_Enter(object sender, EventArgs e)
        {
            textEntered = true;
            //tbxEnterName.Text = "";
           
        }
        private void tbxEnterName_TextChanged(object sender, EventArgs e)
        {
            //if text is entered
            textEntered = true;
            username = tbxEnterName.Text;
            
        }

        private void tbxName_KeyDown(object sender, KeyEventArgs e)
        {
            //check if pressed key is enter
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                frmLeaderboard frmLeaderboard = new frmLeaderboard(totalScore, username);
                frmLeaderboard.Show();
                //makes the button 'to leaderboard' visible
               // btnToLeaderboard.Visible = true;
            }
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {

        }
    }
}
