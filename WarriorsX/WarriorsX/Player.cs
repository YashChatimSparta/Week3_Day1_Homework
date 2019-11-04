using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsX
{
    public class Player
    {
        public int health = 1000;

        public Player() { }

        public int takeDamage()
        {
            health = health - 100;
            return health;
        }
    }



}
