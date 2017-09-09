using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Monster
    {
        public string name;
        public int hp;
        public int attack;
        public float moveSpeed;
        public void Move()
        {
            Console.WriteLine(name + "움직임");
        }

    }
    class Goblin : Monster
    {
        public Goblin()
        {
            name = "고블린";
        }

    }
    class WildPig : Monster
    {
        public WildPig()
        {
            name = "멧돼지";
        }
    }
    class Slime : Monster
    {
        public Slime()
        {
            name = "슬라임";
        }

    }

}
