using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class GameBoard
    {
        // members initalized game board
        // c# will init with zeros.
        int[,] board = new int[7, 7];


        public GameBoard()
        {
            this.board = new int[7, 7];

        }

        public void DropToken(ValueTuple<int, int> token)
        {
            Console.WriteLine(token.Item1 + " " + token.Item2);

            //item1 is your player number, only used on assignment
            //item2 is your slot    
            // i is the row and item2 is the column
            // iterate over the row 
            for (int i = 0; i < board.GetLength(1); i++)
            {

                if (i == 0 && board[i, token.Item2] != 0) //full column
                {
                    Console.WriteLine("Error - That slot is full. Please pick another slot");
                    break;
                }
                if ((i == board.GetLength(1) - 1) && board[i, token.Item2] == 0) // bottom
                {
                    board[i, token.Item2] = token.Item1;
                    break;
                }
                if (board[i, token.Item2] != 0) // mid case
                {
                    board[i - 1, token.Item2] = token.Item1;
                    break;
                }

            }


        }
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" 1 2 3 4 5 6 7");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    sb.Append(" " + board[i, j]);
                }
                sb.AppendLine("");
            }

            return sb.ToString();
        }
    }
}
