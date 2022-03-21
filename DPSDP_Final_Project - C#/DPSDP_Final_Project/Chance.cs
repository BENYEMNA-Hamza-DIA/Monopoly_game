using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    /*This class is sealed because it inherits from Cell but it is not possible to inherit from Chance.
     * This concept is used for all the different types of Cells but not for Property because it is used in our Decorator Pattern.
     */
    public sealed class Chance : Cell 
    {
        #region Attribute
        public int content_chance;
        #endregion

        #region Constructors
        public Chance() { }

        public Chance(int position,int content_chance) : base(position) // base allow to obtain the position from the Cell.
        {
            this.content_chance = RandomContent();
        }
        #endregion

        #region Methods

        /* We have 2 different types of Chance : we pay tax to the bank or earn money.
         * In order to randomize the chance of the player, we use this method.
         */
        public int RandomContent()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 3);
            return result;
        }

        /* A player could earn or pay a tax when he is in a Chance Cell. We randomize this from 10 to 500$.
         */
        public double RandomCash()
        {
            Random rnd = new Random();
            double result = rnd.Next(10, 500);
            return result;
        }

        /* After defining the content of the card, we give the instruction to the player.
         */
        public string Instruction(int content_chance, double random_cash)
        {
            switch(content_chance)
            {
                case 1:
                    {
                        return "Pay $" + random_cash + " for taxes";
                    }
                case 2:
                    {
                        return "Receive $" + random_cash + " from the bank";
                    }
                default:
                    {
                        return "There was an error please try again";
                    }
            }
          
        }
        #endregion
    }


}
