namespace TicTacToe
{
    public partial class PlayBoard : Form
    {

        public PlayBoard()
        {
            InitializeComponent();
            TicTacToe.Init();
            NextCursor();
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var ijAsString = button.Tag?.ToString()?.Split(",") ?? new string[2];

            int i = Int16.Parse(ijAsString[0]);
            int j = Int16.Parse(ijAsString[1]);

            if (TicTacToe.Board[i, j] == BoardValue._)
            {
                var oldPlayer = TicTacToe.NextPlayer;
                bool won = TicTacToe.Play(i, j);
                button.Text = oldPlayer.ToString();

                if (won)
                {
                    winner.Text = $"{oldPlayer} won!";
                    button1x1.Enabled = false;
                    button1x2.Enabled = false;
                    button1x3.Enabled = false;
                    button2x1.Enabled = false;
                    button2x2.Enabled = false;
                    button2x3.Enabled = false;
                    button3x1.Enabled = false;
                    button3x2.Enabled = false;
                    button3x3.Enabled = false;
                }
                else if (won == false)
                        Tie();

                NextCursor();
            }
        }

        private void NextCursor()
        {
            if (TicTacToe.NextPlayer == BoardValue.O)
                this.Cursor = new Cursor(@"Resources\o.ico");
            else if (TicTacToe.NextPlayer == BoardValue.X)
                this.Cursor = new Cursor(@"Resources\x.ico");
        }

        private void Tie()
        {
            if (TicTacToe.Complete)
                winner.Text = "Tie!";
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Reset(button1x1);
            Reset(button1x2);
            Reset(button1x3); 
            Reset(button2x1);
            Reset(button2x2);
            Reset(button2x3);
            Reset(button3x1);
            Reset(button3x2);
            Reset(button3x3);

            TicTacToe.Restart();
        }

        private void Reset(object sender)
        {
            var lastStarter = TicTacToe.lastStarter;

            Button button = (Button)sender;
            button.Enabled = true;
            button.Text = string.Empty;
            winner.Text = string.Empty;
            
            if (TicTacToe.lastStarter == BoardValue.X)
                this.Cursor = new Cursor(@"Resources\o.ico");
            else
                this.Cursor = new Cursor(@"Resources\x.ico");
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tic Tac Toe 1.0\n\nBy Sérgio Filho Paim (2022)\n\n" +
                            $"Source code: https://github.com/sergiofpaim/Tic-Tac-Toe",
                            "About this game");
        }
    }
}