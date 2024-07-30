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
        int totalScore;

        public frmEnd(int argstotalScore)
        {
            InitializeComponent();
            totalScore = argstotalScore;
        }

        private void frmEnd_Load(object sender, EventArgs e)
        {
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
