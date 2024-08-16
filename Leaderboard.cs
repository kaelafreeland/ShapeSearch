using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeSearch_kf
{
    public partial class frmLeaderboard : Form
    {
        private int totalScore;
        private string username;
        private int ranking;

        public frmLeaderboard(int argsTotalScore, string argsUsername)
        {
            InitializeComponent();
            totalScore = argsTotalScore;
            username = argsUsername;
            ranking = -1;
        }

        public frmLeaderboard(int argsTotalScore, string argsUsername, int argsRanking)
        {
            InitializeComponent();
            totalScore = argsTotalScore;
            username = argsUsername;
            ranking = argsRanking;
        }

        private void btnBackToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStartScreen frmStart = new frmStartScreen();
            frmStart.Show();
        }

        private void frmLeaderboard_Load(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("leaderboard.txt"))
            {
                //if totalScore doesn't equal -1000 AND username doesn't equal nameEntered
                if (totalScore != -1000 && username != "nameEntered")
                {
                    //write to text file the username followed by their totalscore
                    sw.WriteLine(totalScore + (" ") + username);
                }

            }


            int lineCount = File.ReadAllLines("leaderboard.txt").Count();
            int[] scores = new int[lineCount];
            string[] players = new string[lineCount];

            int i = 0;
            string line = "";

            using (StreamReader sr = new StreamReader("leaderboard.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(" ");
                    if (data.Length == 2)
                    {
                        int score = Convert.ToInt32(data[0]);
                        scores[i] = score;
                        players[i] = data[1];

                        i++;
                    }
                }
            }


            //sorts the array of scores and players in parallel- puts them in ascending order
            Array.Sort(scores, players);
            //puts the scores in descending order
            Array.Reverse(scores);
            //puts the players in descending order
            Array.Reverse(players);

            rtbLeaderboard.Clear();
            //loops through array of scores and users
            for (i = 0; i < scores.Length; i++)
            {
                //writes the score and user on a line in textbox, a new line for each new user and score (descending)
                rtbLeaderboard.Text += scores[i] + " " + players[i] + "\r\n";
            }



            // If the rank is -1, calculate the rank based on the leaderboard data
            if (ranking == -1 && totalScore != -1000 && username != "nameEntered")
            {
                ranking = CalculateRank(scores, totalScore);
                lblRank.Text = "YOUR RANK: " + ranking.ToString();
            }
            //if totalscore is not -1000 and name is not nameEntered
            else if (totalScore == -1000 && username == "nameEntered")
            {
                lblRank.Text = "NO RANK AVAILABLE";
            }

            int CalculateRank(int[] sortedScores, int playerScore)
            {
                // Find the rank based on the player's score position
                for (int i = 0; i < sortedScores.Length; i++)
                {
                    if (sortedScores[i] == playerScore)
                    {
                        //return index +1
                        return i + 1;
                    }
                }

                return -1; 
            }
        }
            private void lblLeaderBoard_Click(object sender, EventArgs e)
        {

        }

        private void rtbLeaderboard_TextChanged(object sender, EventArgs e)
        {

        }
    }





}
