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
            ValueTuple<int, int> tokenToDrop = new();
            Console.WriteLine(board.ToString());



            Console.WriteLine("Pick a Slot 1 - 7 to drop your token in.");
            tokenToDrop.Item1 = 1;
            tokenToDrop.Item2 = 2;
            board.DropToken(tokenToDrop);
            if (board.CheckForConnect(tokenToDrop)) { GameOver(); }
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 1;
            tokenToDrop.Item2 = 3;
            board.DropToken(tokenToDrop);
            board.CheckForConnect(tokenToDrop);
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 1;
            tokenToDrop.Item2 = 4;
            board.DropToken(tokenToDrop);
            board.CheckForConnect(tokenToDrop);
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 1;
            tokenToDrop.Item2 = 5;
            board.DropToken(tokenToDrop);
            if (board.CheckForConnect(tokenToDrop)) { GameOver(); }
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 1;
            tokenToDrop.Item2 = 3;
            board.DropToken(tokenToDrop);
            if (board.CheckForConnect(tokenToDrop)) { GameOver(); }
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 4;
            tokenToDrop.Item2 = 6;
            board.DropToken(tokenToDrop);
            if (board.CheckForConnect(tokenToDrop)) { GameOver(); }
            Console.WriteLine(board.ToString());
            tokenToDrop.Item1 = 4;
            tokenToDrop.Item2 = 6;
            board.DropToken(tokenToDrop);
            if (board.CheckForConnect(tokenToDrop)) { GameOver(); }
            Console.WriteLine(board.ToString());

            void GameOver()
            {
                Console.WriteLine("You Connected Four! Congratualtions! Game Over.");
            }
        }
    }
}

