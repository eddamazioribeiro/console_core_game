using System;

namespace Game
{
    public class Player
    {
        public readonly string _name;

        public Player(string name)
        {
            _name = name;
        }

        public void Attack()
        {
            Console.Write($"{_name} attacked!\n");
        }

        public void Defend()
        {
            Console.Write($"{_name} defended!\n");
        }

        public void Flee()
        {
            Console.Write($"{_name} run away!\n");
        }
    }
}