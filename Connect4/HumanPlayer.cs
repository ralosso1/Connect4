using System;

namespace Connect4
{
    //moves come from keyboard input
    class HumanPlayer : Player
    {
        public HumanPlayer(string name, char symbol) : base(name, symbol)
        {
        }

        public override int GetMove()
        {
            while (true)
            {
                Console.Write(Name + " (" + Symbol + "), pick a column (1-7): ");
                string input = Console.ReadLine();
                int col;
                if (int.TryParse(input, out col) && col >= 1 && col <= 7)
                {
                    return col - 1;
                }
                Console.WriteLine("Choose a number between 1 to 7.");
            }
        }
    }
}