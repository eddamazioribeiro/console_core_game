using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerOne = new Player();
            var playerTwo = new NPC("Foe");
            var game = new Game(playerOne, playerTwo);

            game.Start();
        }
    }
}