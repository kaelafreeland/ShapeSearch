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
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
            
        }

        private void frmGame_Load(object sender, EventArgs e)
        {

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
    }
}
