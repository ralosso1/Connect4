using System;

namespace Connect4
{
    //7x6 grid and disc placement and win checks
    class Board
    {
        private const int Rows = 6;
        private const int Cols = 7;
        private char[,] grid = new char[Rows, Cols];

        public Board()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    grid[i, j] = '.';
                }
            }
        }

        //drop disc in collumn and returns if its not valid
        public bool DropDisc(int col, char symbol)
        {
            if (col < 0 || col >= Cols)
                return false;

            for (int i = Rows - 1; i >= 0; i--)
            {
                if (grid[i, col] == '.')
                {
                    grid[i, col] = symbol;
                    return true;
                }
            }
            return false;
        }

        public bool IsFull()
        {
            for (int j = 0; j < Cols; j++)
            {
                if (grid[0, j] == '.')
                    return false;
            }
            return true;
        }

        //checks all four directions 
        public bool CheckWin(char symbol)
        { //horizontal
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols - 3; j++)
                {
                    if (grid[i, j] == symbol && grid[i, j + 1] == symbol
                        && grid[i, j + 2] == symbol && grid[i, j + 3] == symbol)
                    {
                        return true;
                    }
                }
            }

            //vertical
            for (int j = 0; j < Cols; j++)
            {
                for (int i = 0; i < Rows - 3; i++)
                {
                    if (grid[i, j] == symbol && grid[i + 1, j] == symbol
                        && grid[i + 2, j] == symbol && grid[i + 3, j] == symbol)
                    {
                        return true;
                    }
                }
            }

            //diagonal right
            for (int i = 0; i < Rows - 3; i++)
            {
                for (int j = 0; j < Cols - 3; j++)
                {
                    if (grid[i, j] == symbol && grid[i + 1, j + 1] == symbol
                        && grid[i + 2, j + 2] == symbol && grid[i + 3, j + 3] == symbol)
                    {
                        return true;
                    }
                }
            }

            //diagonal left (/)
            for (int i = 0; i < Rows - 3; i++)
            {
                for (int j = 3; j < Cols; j++)
                {
                    if (grid[i, j] == symbol && grid[i + 1, j - 1] == symbol
                        && grid[i + 2, j - 2] == symbol && grid[i + 3, j - 3] == symbol)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void PrintBoard()
        {
            Console.WriteLine();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("1 2 3 4 5 6 7");
            Console.WriteLine();
        }
    }
}