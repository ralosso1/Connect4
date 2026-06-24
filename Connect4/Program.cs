using System;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connect Four");
            Console.WriteLine("------------");

            Board board = new Board();
            board.PrintBoard();
        }
    }
}