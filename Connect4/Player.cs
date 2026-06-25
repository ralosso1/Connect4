namespace Connect4
{
    abstract class Player
    {
        public string Name;
        public char Symbol;

        public Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public abstract int GetMove();
    }
}