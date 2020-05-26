namespace Game
{
    public class Game
    {
        private readonly Player _playerOne;

        public Game(Player player)
        {
            _playerOne = player;
        }
        
        public void Start()
        {
            System.Console.Write($"Player {_playerOne._name} started the game\n");
            
            _playerOne.Attack();
            _playerOne.Defend();
        }
    }
}