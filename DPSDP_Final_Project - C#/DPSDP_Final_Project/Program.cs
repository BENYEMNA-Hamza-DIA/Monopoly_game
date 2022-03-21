using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    class Program
    {
        /*Static methods implemented to do the tests. We settle Players on a defined state of the Game (inputs)
         * for an expected output.
        */
        static void TestDoubleDice()
        {
            Player p1 = new Player("p1", 0, 1500, false, null, false);
            Player p2 = new Player("p2", 0, 1500, false, null, false);
            List<Player> players = new List<Player>();
            players.Add(p1);
            players.Add(p2);

            Game monopoly = new Game();
            monopoly.StartDoubleDice(players);
        }

        static void TestTripleDiceJail()
        {
            Player p1 = new Player("p1", 0, 1500, false, null, false);
            Player p2 = new Player("p2", 0, 1500, false, null, false);
            List<Player> players = new List<Player>();
            players.Add(p1);
            players.Add(p2);

            Game monopoly = new Game();
            monopoly.StartTripleDice(players);
        }

        static void TestBuyProperty()
        {
            //Buy a property at position 9.
            Player p1 = new Player("p1", 0, 1500, false, null, false);
            Player p2 = new Player("p2", 0, 1500, false, null, false);
            List<Player> players = new List<Player>();
            players.Add(p1);
            players.Add(p2);

            Game monopoly = new Game();
            monopoly.StartBuyProperty(players);
        }


        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            //You can find bellow the code to execute the Tests.
            #region Test Cases

            #region Double Dice
            //TestDoubleDice();
            #endregion

            #region Triple Dice + Go To Jail
            //TestTripleDiceJail();
            #endregion

            #region Buy Property
            //TestBuyProperty();
            #endregion
            #endregion


            Game monopoly = new Game();
            players = monopoly.Create();
            monopoly.Start(players);

            Console.ReadKey();

        
        }
    }
}
