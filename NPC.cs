namespace Game
{
    public class NPC : IPlayer
    {
        
        public string Name()
        {
            return $"{Name()}";
        }
        
        public string Attack()
        {
            return $"{Name()} attacked!";
        }

        public string Defend()
        {
            return $"{Name()} defended!";
        }

        public string Flee()
        {
            return $"{Name()} fled!";
        }
    }
}