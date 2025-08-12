using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattle
{
    internal class Controller
    {
        private List<Unit> _partyModel;
        private List<Unit> _monsterModel;

        public List<Unit> PartyModel { get => _partyModel; set => _partyModel = value; }
        public List<Unit> MonsterModel { get => _monsterModel; set => _monsterModel = value; }

        public static void displayCMDlist()
        {
            Console.WriteLine("[1] Attack");
            Console.WriteLine("[2] Skill");
            Console.WriteLine("[3] Item");
        }
    }
}
