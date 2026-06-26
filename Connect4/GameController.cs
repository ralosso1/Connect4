using System;

namespace Connect4
{
    //start screen, game loop, restart
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

                Console.Write("Play again? (y/n): ");
                string answer = Console.ReadLine();
                if (answer == null || answer.Trim().ToLower() != "y")
                {
                    keepPlaying = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
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
                    Console.WriteLine("That column is full. Try again.");
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
                    Console.WriteLine("It's a draw!");
                    gameOver = true;
                }

                turn++;
            }
        }
    }
}