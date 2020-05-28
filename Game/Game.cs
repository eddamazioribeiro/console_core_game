using Game.Interface;
using System;

namespace Game
{
    public class Game
    {
        private readonly IPlayer _playerOne;
        private readonly IPlayer _playerTwo;

        public Game(IPlayer playerOne, IPlayer playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
        }
        
        public void Start()
        {
            System.Console.Write($"Player {_playerOne.Name()} started the game\n");
            
            Console.Write($"\n{_playerOne.Name()} turn\n".ToUpper());
            Console.Write(_playerOne.Attack());
            Console.Write(_playerOne.Defend());
            Console.Write($"\n{_playerOne.Name()} turn ended\n".ToUpper());

            Console.Write($"\n{_playerTwo.Name()} turn\n".ToUpper());
            Console.Write(_playerTwo.Flee());
            Console.Write($"\n{_playerTwo.Name()} turn ended\n".ToUpper());
        }
    }
}