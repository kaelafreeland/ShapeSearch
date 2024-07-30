namespace ShapeSearch_kf
{
    public partial class frmStartScreen : Form
    {
        public frmStartScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblShapeSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //hide current form
            this.Hide();
            //creates and opens game screen and makes form variable to address throughout code
            frmGame frmGame = new frmGame();
            //opens game form
            frmGame.Show();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHowToPlay frmHowToPlay = new frmHowToPlay();
            frmHowToPlay.Show();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLeaderboard frmLeaderboard = new frmLeaderboard(-1000, "nameEntered");
            frmLeaderboard.Show();
        }
    }
}