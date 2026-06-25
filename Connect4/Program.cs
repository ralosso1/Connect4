using System;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connect Four");
            Console.WriteLine("------------");

            Player p1 = new Player("Player 1", 'X');
            Player p2 = new Player("Player 2", 'o');

            Board board = new Board();

            //this is where the game is going to loop
            Player current = p1;
            while (true)
            {
                board.PrintBoard();
                Console.Write(current.Name + " (" + current.Symbol + "), choose a column (1-7): ");
                string input = Console.ReadLine();
                int col = int.Parse(input);

                board.DropDisc(col, current.Symbol);

                //switching the player
                if (current == p1)
                    current = p2;
                else
                    current = p1;
            }
        }
    }
}