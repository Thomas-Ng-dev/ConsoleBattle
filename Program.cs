using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster m1 = new Monster("Goblin", 100, 100, 10, 10, 10, 10);
            PartyMember p1 = new PartyMember("Hero", 100, 100, 10, 10, 10, 10);

            m1.remainingHP();
            p1.remainingHP();

            m1.atkCmd(p1);
            p1.atkCmd(m1);

        }
    }
}