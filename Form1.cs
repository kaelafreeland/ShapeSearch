namespace ShapeSearch_kf
{
    public partial class StartScreen : Form
    {
        public StartScreen()
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
            //creates and opens game screen
            frmGame frmGame = new frmGame();
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
            frmLeaderboard frmLeaderboard = new frmLeaderboard();
            frmLeaderboard.Show();
        }
    }
}