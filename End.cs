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
    public partial class frmEnd : Form
    {
        private int totalScore;

        public frmEnd(int score)
        {
            InitializeComponent();
            totalScore = score;
            lblPoints.Text = totalScore.ToString();
        }

        private void btnToLeaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLeaderboard frmLeaderboard = new frmLeaderboard();
            frmLeaderboard.Show();

        }
    }
}
