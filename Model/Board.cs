using System.Text;

namespace TicTacToe
{
    public enum BoardValue
    {
        _,
        X,
        O
    }

    public class Board 
    {
        readonly BoardValue[,] boardValue = new BoardValue[3, 3];
        public BoardValue this[int i, int j]
        {
            get => boardValue[i, j];
            set => boardValue[i, j] = value;
        }
    }
}
