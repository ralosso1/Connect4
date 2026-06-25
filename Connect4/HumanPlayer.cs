using System;

namespace Connect4
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name, char symbol) : base(name, symbol)
        {
        }

        public override int GetMove()
        {
            while (true)
            {
                Console.Write(Name + " (" + Symbol + "), pick a collumn (1-7): ");
                string input = Console.ReadLine();
                int col;
                if (int.TryParse(input, out col))
                {
                    if (col >= 1 && col <= 7)
                    {
                        return col - 1;
                    }
                }
                Console.WriteLine("only enter a number from 1 to 7.");
            }
        }
    }
}