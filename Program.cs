using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerOne = new Player("Bob");
            var game = new Game(playerOne);

            game.Start();
        }
    }
}