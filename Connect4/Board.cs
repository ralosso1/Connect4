using System;

namespace Connect4
{
    class Board
    {
        private char[,] grid = new char[6, 7];

        public Board()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    grid[i, j] = '.';
                }
            }
        }

        public void DropDisc(int col, char symbol)
        {
            // put disc in the column
            for (int i = 0; i < 6; i++)
            {
                if (grid[i, col] == '.')
                {
                    grid[i, col] = symbol;
                    break;
                }
            }
        }

        public void PrintBoard()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("1 2 3 4 5 6 7");
        }
    }
}