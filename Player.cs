using System;

namespace Game
{
    public class Player : IPlayer
    {
        public readonly string _name;

        public Player(string name = "Hero")
        {
            _name = name;
        }

        public string Name()
        {   
            return _name;
        }

        public string Attack()
        {
            return $"{_name} attacked!\n";
        }

        public string Defend()
        {
            return $"{_name} defended!\n";
        }

        public string Flee()
        {
            return $"{_name} run away!\n";
        }
    }
}