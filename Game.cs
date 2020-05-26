namespace Game
{
    public class Game
    {
        private readonly IPlayer _playerOne;

        public Game(IPlayer player)
        {
            _playerOne = player;
        }
        
        public void Start()
        {
            System.Console.Write($"Player {_playerOne.Name()} started the game\n");
            
            _playerOne.Attack();
            _playerOne.Defend();
        }
    }
}