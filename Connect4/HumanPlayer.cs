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
            Console.Write(Name + " (" + Symbol + "), pick a column (1-7): ");
            string input = Console.ReadLine();
            int col = int.Parse(input);
            return col - 1;
        }
    }
}