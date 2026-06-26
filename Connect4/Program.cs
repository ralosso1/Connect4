namespace Connect4
{
    //entree point for the game
    class Program
    {
        static void Main(string[] args)
        {
            GameController game = new GameController();
            game.Run();
        }
    }
}