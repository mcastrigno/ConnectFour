using System;

namespace ConnectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConnectFour! Let's Play!");
            Console.WriteLine();
            GameBoard board = new();
            Console.WriteLine(board.ToString());



            Console.WriteLine("Pick a Slot 1 - 7 to drop your token in.");
            //(int, int) tokenToDrop = (1,1);
            ValueTuple<int, int> tokenToDrop = new();
            tokenToDrop.Item1 = 1;
            tokenToDrop.Item2 = 2;
            board.DropToken(tokenToDrop);
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 4;
            tokenToDrop.Item2 = 6;
            board.DropToken(tokenToDrop);
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 4;
            tokenToDrop.Item2 = 6;
            board.DropToken(tokenToDrop);
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 4;
            tokenToDrop.Item2 = 6;
            board.DropToken(tokenToDrop);
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 4;
            tokenToDrop.Item2 = 6;
            board.DropToken(tokenToDrop);
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 4;
            tokenToDrop.Item2 = 6;
            board.DropToken(tokenToDrop);
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 4;
            tokenToDrop.Item2 = 6;
            board.DropToken(tokenToDrop);
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 4;
            tokenToDrop.Item2 = 6;
            board.DropToken(tokenToDrop);
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 4;
            tokenToDrop.Item2 = 6;
            board.DropToken(tokenToDrop);
            Console.WriteLine(board.ToString());
        }
    }
}
