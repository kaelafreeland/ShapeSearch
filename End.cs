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

       

        public frmEnd(int argstotalScore)
        {
            InitializeComponent();
            totalScore = argstotalScore;
        }

        private void frmEnd_Load(object sender, EventArgs e)
        {
            //write points gained to label
            lblPoints.Text = "YOU SCORED " + totalScore.ToString() + " POINTS";
            tbxEnterName.Text = " ENTER NAME HERE...";


        }

        private void tbxEnterName_Enter(object sender, EventArgs e)
        {
            if (tbxEnterName.Text == " ENTER NAME HERE...")
            {
                tbxEnterName.Text = "";
            }

        }

        private void tbxEnterName_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(tbxEnterName.Text))
            {
                tbxEnterName.Text = " ENTER NAME HERE...";
               
            }

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

            }
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {

        }
    }
}
