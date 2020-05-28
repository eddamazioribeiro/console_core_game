using Game.Interface;

namespace Game.Lib
{
    public class NPC : IPlayer
    {
        private string _name;

        public NPC(string name = "Foe")
        {
            _name = name;
        }

        public string Name()
        {
            return _name;
        }
        
        public string Attack()
        {
            return $"{Name()} attacked!\n";
        }

        public string Defend()
        {
            return $"{Name()} defended!\n";
        }

        public string Flee()
        {
            return $"{Name()} fled!\n";
        }
    }
}