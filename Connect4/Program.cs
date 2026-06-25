using System;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connect Four");
            Console.WriteLine("------------");

            HumanPlayer p1 = new HumanPlayer("Player 1", 'X');
            HumanPlayer p2 = new HumanPlayer("Player 2", 'O');

            Board board = new Board();

            Player current = p1;
            bool gameOver = false;
//Game loops
            while (!gameOver)
            {
                board.PrintBoard();
                int col = current.GetMove();

                bool placed = board.DropDisc(col, current.Symbol);
                if (!placed)
                {
                    Console.WriteLine("Collum is full, choose another collum.");
                    continue;
                }

                if (board.CheckWin(current.Symbol))
                {
                    board.PrintBoard();
                    Console.WriteLine(current.Name + " wins!");
                    gameOver = true;
                }
//switching the player
                if (current == p1)
                    current = p2;
                else
                    current = p1;
            }
        }
    }
}