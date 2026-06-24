using System;

namespace Connect4
{
    class Board
    {
        private char[,] grid = new char[6, 7];

        public Board()
        {
            //these are the  spaces for the connect 4
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    grid[i, j] = '.';
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
        }
    }
}