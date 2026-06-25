using System;

namespace Connect4
{
    class GameController
    {
        private Board board;
        private Player[] players;

        public GameController()
        {
            players = new Player[2];
        }

        public void Run()
        {
            bool keepPlaying = true;

            while (keepPlaying)
            {
                StartScreen();
                PlayGame();

                Console.Write("Do you want to play again (y/n): ");
                string answer = Console.ReadLine();
                if (answer != "y")
                {
                    keepPlaying = false;
                }
            }

        }

        private void StartScreen()
        {
            Console.Clear();
            Console.WriteLine("=== Connect Four ===");
            Console.WriteLine();

            board = new Board();
            players[0] = new HumanPlayer("Player 1", 'X');
            players[1] = new HumanPlayer("Player 2", 'O');
        }

        private void PlayGame()
        {
            int turn = 0;
            bool gameOver = false;

            while (!gameOver)
            {
                Player current = players[turn % 2];
                board.PrintBoard();

                int col = current.GetMove();
                bool placed = board.DropDisc(col, current.Symbol);

                if (!placed)
                {
                    Console.WriteLine("Try again");
                    continue;
                }

                if (board.CheckWin(current.Symbol))
                {
                    board.PrintBoard();
                    Console.WriteLine(current.Name + " wins!");
                    gameOver = true;
                }
                else if (board.IsFull())
                {
                    board.PrintBoard();
                    Console.WriteLine("the game has been draw!");
                    gameOver = true;
                }

                turn++;
            }
        }
    }
}