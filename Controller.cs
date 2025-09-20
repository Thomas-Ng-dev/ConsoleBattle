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

		public Controller(List<Unit> partyModel, List<Unit> monsterModel)
		{
			_partyModel = partyModel;
			_monsterModel = monsterModel;
		}

		public List<Unit> PartyModel { get => _partyModel; set => _partyModel = value; }
        public List<Unit> MonsterModel { get => _monsterModel; set => _monsterModel = value; }

        public static void DisplayCommadList()
        {
			Console.WriteLine("|----------------|");
			Console.WriteLine("|[1] Attack		|");
            Console.WriteLine("|[2] Defend		|");
            Console.WriteLine("|[3] Skill		|");
			Console.WriteLine("|[4] Item		|");
			Console.WriteLine("|----------------|");
		}
		public static void CommandSelection()
		{
			// Get user input to select a command
		}
		public static void EvaluateGameState(Controller controlle)
		{
			// Check if game is over if any units hp = 0
		}
    }
}
