namespace FrogWinFormsApp
{
    public partial class GameMainForm : Form
    {
        private int counterMoves = 0;

        private Point positionR1;
        private Point positionR2;
        private Point positionR3;
        private Point positionR4;

        private Point positionCenter;

        private Point positionL4;
        private Point positionL3;
        private Point positionL2;
        private Point positionL1;


        public GameMainForm()
        {
            InitializeComponent();

            positionR1 = RightPictureBox1.Location;
            positionR2 = RightPictureBox2.Location;
            positionR3 = RightPictureBox3.Location;
            positionR4 = RightPictureBox4.Location;

            positionCenter = EmptyPictureBox.Location;

            positionL1 = LeftPictureBox1.Location;
            positionL2 = LeftPictureBox2.Location;
            positionL3 = LeftPictureBox3.Location;
            positionL4 = LeftPictureBox4.Location;
        }



        private void PictureBox3_Click(object sender, EventArgs e)
        {
            var clickedFrog = (PictureBox)sender;
            var distance = Math.Abs((clickedFrog.Location.X - EmptyPictureBox.Location.X) / clickedFrog.Size.Width);

            if (distance <= 2)
            {
                var location = clickedFrog.Location;
                clickedFrog.Location = EmptyPictureBox.Location;
                EmptyPictureBox.Location = location;

                counterMoves++;
                CounterMovesLabel.Text = counterMoves.ToString();
            }

            if (IsGameFinished())
            {
                if (counterMoves > 24)
                {
                    EndGamePictureBox.Image = Properties.Resources.game_over;
                    ShowPictureEndGame();
                }
                else
                {
                    EndGamePictureBox.Image = Properties.Resources.game_done;
                    ShowPictureEndGame();
                }
            }
        }


        private void ShowPictureEndGame()
        {
            EndGamePictureBox.Size = this.Size;
            EndGamePictureBox.Visible = true;
        }


        public bool IsGameFinished()
        {
            var resultCount = 0;

            if (EmptyPictureBox.Location.X == positionCenter.X)
            {
                if (RightPictureBox1.Location.X > positionCenter.X) resultCount++;
                if (RightPictureBox2.Location.X > positionCenter.X) resultCount++;
                if (RightPictureBox3.Location.X > positionCenter.X) resultCount++;
                if (RightPictureBox4.Location.X > positionCenter.X) resultCount++;
            }

            return resultCount == 4;
        }


        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            counterMoves = 0;
            CounterMovesLabel.Text = counterMoves.ToString();
            EndGamePictureBox.Visible = false;

            RightPictureBox1.Location = positionR1;
            RightPictureBox2.Location = positionR2;
            RightPictureBox3.Location = positionR3;
            RightPictureBox4.Location = positionR4;

            EmptyPictureBox.Location = positionCenter;

            LeftPictureBox1.Location = positionL1;
            LeftPictureBox2.Location = positionL2;
            LeftPictureBox3.Location = positionL3;
            LeftPictureBox4.Location = positionL4;
        }
    }
}
