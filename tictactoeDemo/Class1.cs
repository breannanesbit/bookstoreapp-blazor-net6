namespace tictactoeDemo
{
    public class TicTacToe
    {
        public string currPlayer = "X";

        private string[,] board;

        public TicTacToe()
        {
            board = new string[3, 3];
        }
        public bool setCell(string x, int p1, int p2)
        {
            if(board[p1,p2] == null)
            {
                board[p1,p2] = x;
                Turn();
                return true;
            }
            else
                return false;
        }

        public string getCell(int p1, int p2)
        {
            return board[p1,p2];
        }

        public string Winner()
        {
            if(board[0,0] == board[1,0] && board[1,0] == board[2,0] || board[0,0] == board[0,1] && board[0,1] == board[0,2] || board[0, 0] == board[1, 1] && board[1, 0] == board[2, 2] && board[0, 0] != null)
            {
                return board[0, 0];

            }
            else if(board[1,0] == board[1,1] && board[1,0] == board[1,2] || board[0,1] == board[1,1] && board[1,1] == board[2,1] || board[1,1] == board[0,2] && board[1,1] == board[2,0] && board[1, 1] != null)
            {
                return board[1, 1];
            }
            else if(board[0,2] == board[1,2] && board[1,2] == board[2,2] || board[2,2] == board[2,1] && board[2,2] == board[2,0] && board[2,2] != null)
            {
                return board[2, 2];
            }
            else
            {
                return "none";
            }
        }

        public string Turn()
        {
            if(currPlayer == "X")
            {
                currPlayer = "O";
                return currPlayer;
            }
            else
            {
                currPlayer = "X";
                return currPlayer;
            }
        }
    }
}