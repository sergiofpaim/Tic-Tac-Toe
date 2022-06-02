namespace TicTacToe
{ 
    public static class TicTacToe 
    {
        public static bool Complete => countRounds == 9;
        private static int countRounds = 0;

        public static BoardValue lastStarter = BoardValue.X;
        private static BoardValue nextPlayer = BoardValue.X;

        public static Board Board { get; internal set; } = new();
        public static BoardValue NextPlayer { get => nextPlayer; }

        public static void Init()
        {
            ResetBoard();
        }

        public static bool Play(int i, int j)
        {
            if (i > 2 || i < 0)
                throw new Exception("i must be between 0 and 2");
            
            if (j > 2 || j < 0)
                throw new Exception("j must be between 0 and 2");

            if (Board[i, j] != BoardValue._)
                throw new Exception("This cell is already played");

            Board[i, j] = nextPlayer;

            ChangePlayer();

            countRounds++;
            
            return CheckGame(i, j);
        }

        public static void Restart()
        {
            if (lastStarter == BoardValue.X)
                lastStarter = BoardValue.O;
            else
                lastStarter = BoardValue.X;
            
            nextPlayer = lastStarter;

            ResetBoard();
        }

        private static void ResetBoard()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Board[i, j] = BoardValue._;

            countRounds = 0;
        }

        private static void ChangePlayer()
        {
            if (nextPlayer == BoardValue.X)
                nextPlayer = BoardValue.O;
            else
                nextPlayer = BoardValue.X;
        }

        private static bool CheckGame(int i, int j)
        {
            BoardValue lastPlay = Board[i, j];

            bool rowCheck = true;
            for (int col = 0; col < 3; col++)
                if (Board[i, col] != lastPlay)
                    rowCheck = false;
            
            bool colCheck = true;
            for (int row = 0; row < 3; row++)
                if (Board[row, j] != lastPlay)
                    colCheck = false;

            bool descDiagonalCheck = false;
            if (i == j)
            {
                descDiagonalCheck = true;
                for (int rowCol = 0; rowCol < 3; rowCol++)
                    if (Board[rowCol, rowCol] != lastPlay)
                        descDiagonalCheck = false;
            }          
            
            bool ascDiagonalCheck = false;
            if ((i == 1 && j == 1) || 
                (i == 0 && j == 2) ||
                (i == 2 && j == 0))
            {
                ascDiagonalCheck = true;
                for (int rowCol = 0; rowCol < 3; rowCol++)
                    if (Board[2 - rowCol, rowCol] != lastPlay)
                        ascDiagonalCheck = false;
            }

            return rowCheck || colCheck || descDiagonalCheck || ascDiagonalCheck;
        }
    }
}
