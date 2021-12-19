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
        ValueTuple<int, int> lastToken = new();
        int lastRow_X;
        int lastCol_Y;


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
                    lastToken = (i, token.Item2);
                    break;
                }
                if (board[i, token.Item2] != 0) // mid case
                {
                    board[i - 1, token.Item2] = token.Item1;
                    lastToken = (i - 1, token.Item2);
                    break;
                }
            }
        }

        public bool CheckForConnect(ValueTuple<int, int> token)
        {
            bool connected = false;

            // check vertical - only down as you are at the top
            if (lastToken.Item1 > 3) { connected = false; } // not enough depth
            else if ((board[lastToken.Item1, lastToken.Item2] == board[lastToken.Item1 + 1, lastToken.Item2])
            && (board[lastToken.Item1, lastToken.Item2] == board[lastToken.Item1 + 1, lastToken.Item2])
            && (board[lastToken.Item1, lastToken.Item2] == board[lastToken.Item1 + 1, lastToken.Item2]))

            {
                connected = true;
            }

            // go to the the "left" of the array to find the edge and then go right and count
            bool foundHorzStart = false;
            int horzStart = 0;
            int horzPointer = lastToken.Item2;
            int sequenceCount = 0;
            while (!foundHorzStart)
            {
                horzPointer -= 1;
                if (lastToken.Item2 == 0)//case for at the 0 column
                {
                    foundHorzStart = true;
                    sequenceCount = 1;
                    horzStart = 0;//could be removed, here for clarity
                    break;
                } else if (board[lastToken.Item1, horzPointer] != token.Item1)// go negative see if we are the edge if not continue looking
                {
                    foundHorzStart = true;
                    sequenceCount = 1;
                    horzStart = horzPointer + 1;
                    break;
                }
            }
            Console.WriteLine("we found the horizontal start at " + horzStart + " " + foundHorzStart);
            for (int i = horzStart; i < board.GetLength(1); i++)
            {
                if (board[lastToken.Item1, lastToken.Item2] == board[lastToken.Item1, horzStart + 1])
                {
                    sequenceCount += 1;
                    if (sequenceCount == 4)
                    {
                        connected = true;
                        break;
                    }
                } else
                {
                    break;
                }

            }

            // check positive slope diagonl go negative to find the first one and go pos slope diag from there

            // check negitive slope diagonal go negiteve to find the first one and go neg slope diag from there
            return connected;

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
