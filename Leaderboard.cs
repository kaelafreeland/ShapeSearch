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

        public frmLeaderboard(int argsTotalScore, string argsUsername)
        {
            InitializeComponent();
            totalScore = argsTotalScore;
            username = argsUsername;
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

            //loops through array of scores and users
            for (i = 0; i < scores.Length; i++)
            {
                //writes the score and user on a line in textbox, a new line for each new user and score (descending)
                rtbLeaderboard.Text += scores[i] + " " + players[i] + "\r\n";

            }

        }
        private void lblLeaderBoard_Click(object sender, EventArgs e)
        {

        } 
    }

        

      
    
}
