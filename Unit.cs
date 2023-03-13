using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattle
{
    class Unit
    {
        private string _name;
        private int _hp;
        private int _mp;
        private int _str;
        private int _mag;
        private int _def;
        private int _spr;

        public Unit(string name, int hp, int mp, int str, int mag, int def, int spr)
        {
            Name = name;
            Hp = hp;
            Mp = mp;
            Str = str;
            Mag = mag;
            Def = def;
            Spr = spr;
        }
        public string Name { get => _name; set => _name = value; }
        public int Hp { get => _hp; set => _hp = value; }
        public int Mp { get => _mp; set => _mp = value; }
        public int Str { get => _str; set => _str = value; }
        public int Mag { get => _mag; set => _mag = value; }
        public int Def { get => _def; set => _def = value; }
        public int Spr { get => _spr; set => _spr = value; }

    }
}
