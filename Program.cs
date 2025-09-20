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
            int turn = 1;
            String repeat = "";
            Unit m1 = new Monster("Goblin", 100, 100, 20, 10, 10, 10);
            Unit p1 = new PartyMember("Hero", 100, 100, 10, 10, 10, 10);
            List<Unit> monsters = new List<Unit>();
            List<Unit> party = new List<Unit>();
            monsters.Add(m1);
            party.Add(p1);
            Controller controller = new Controller(party, monsters);
            do
            {
                Console.WriteLine("Turn " + turn);
                //m1.remainingHP();
                //p1.remainingHP();

                //m1.atkCmd(p1);

                //m1.remainingHP();
                //p1.remainingHP();
                //if (m1.Hp <= 0 || p1.Hp <= 0)
                //{
                //	break;
                //}
                controller.MonsterModel[0].RemainingHP();
                controller.PartyModel[0].RemainingHP();

                controller.MonsterModel[0].AtkCmd(controller.PartyModel[0]);

                controller.MonsterModel[0].RemainingHP();
                controller.PartyModel[0].RemainingHP();

                if (controller.MonsterModel[0].Hp <= 0 || controller.PartyModel[0].Hp <= 0)
                {
                    break;
                }
                turn++;

                
                Console.WriteLine("Another turn?");
                repeat = Console.ReadLine();
            }
            while (repeat.Equals("y"));
            Console.WriteLine("Game Over");
        }
    }
}
