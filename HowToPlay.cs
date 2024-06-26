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
    public partial class frmHowToPlay : Form
    {
        public frmHowToPlay()
        {
            InitializeComponent();
        }

        private void frmHowToPlay_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStartScreen frmStart = new frmStartScreen();
            frmStart.Show();
        }
    }
}
