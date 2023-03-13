using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattle
{
    internal class Monster : Unit
    {
        public Monster(string name, int hp, int mp, int str, int mag, int def, int spr) : base(name, hp, mp, str, mag, def, spr)
        {
            Name = name;
            Hp = hp;
            Mp = mp;
            Str = str;
            Mag = mag;
            Def = def;
            Spr = spr;
        }

    }
}
