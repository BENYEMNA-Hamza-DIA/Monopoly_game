using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    class Player
    {
        #region Attributes
        public string name; // the name of the player.
        public int position = 0; // the player's position on the board.
        public double money = 1500; // how much money the player owns.
        public bool jail = false; // if true then the player is in jail.
        public List<Property> properties = new List<Property>(); // the list of the properties owned by the player.
        public bool loser = false;
        #endregion

        #region Constructors
        public Player() { }

        public Player(string Name) { this.name = Name; } // When we create a Player, we have to create it only with a given name.

        public Player(string Name, int Position, long Money, bool Jail, List<Property> Properties, bool Loser)
        {
            this.name = Name;
            this.position = Position;
            this.money = Money;
            this.jail = Jail;
            this.properties = Properties;
            this.loser = Loser;
        }
        #endregion

        #region Proprieties

        public string Name { get => name; set => name = value; }
        public int Position { get => position; set => position = value; }
        public double Money { get => money; set => money = value; }
        public bool Jail { get => jail; set => jail = value; }
        public List<Property> Properties { get => properties; set => properties = value; }
        public bool Loser { get => loser; set => loser = value; }
        #endregion

        #region Methods
        public string toString()
        {
            
            int nb_prop = 0;
            if (properties != null)
            {
                nb_prop = properties.Count();
            }
            Console.WriteLine("Proprerties of : " + name);

            for (int i = 0; i < properties.Count; i++)
            {
                Console.WriteLine(properties[i].toString());
            }
            return "\nPlayer: " + name + "\nPosition: " + position + "\nMoney: $" + money + "\nProperties: " + properties.Count();
        }

        public int[] RollDices() // Used to roll the dices.
        {
            Random rnd = new Random();
            int value1 = rnd.Next(1, 7);
            int value2 = rnd.Next(1, 7);
            int total = value1 + value2;
            Console.WriteLine("Dice 1 :" + value1);
            Console.WriteLine("Dice 2 :" + value2);
            Console.WriteLine("Total =" + total);
            int[] tab = new int[2];
            tab[0] = value1;
            tab[1] = value2;
            return tab;
        }

        public bool DoubleBool(int[] tab) //Verify if the dice roll is a double or not.
        {
            if (tab[0] == tab[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(int number) // This method is used to move the player and to make the the board Cells 39 and 0 connected.
        {
            if (position + number < 40)
            {
                position += number;
            }
            else
            {
                position = position + number - 40;
                money += 200;
            }
        }
        #endregion


    }
}
