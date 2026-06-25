using System;

namespace Connect4
{
    class Board
    {
        private char[,] grid = new char[6, 7];
    //game loops 
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

        public bool DropDisc(int col, char symbol)
        {
            if (col < 0 || col > 6)
                return false;
//drop disc to lowest empty spot
            for (int i = 5; i >= 0; i--)
            {
                if (grid[i, col] == '.')
                {
                    grid[i, col] = symbol;
                    return true;
                }
            }
            return false;
        }

        public bool CheckWin(char symbol)
        {
            //checking th horizontal 
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (grid[i, j] == symbol && grid[i, j + 1] == symbol
                                             && grid[i, j + 2] == symbol && grid[i, j + 3] == symbol)
                    {
                        return true;
                    }
                }
            }
            return false;
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