using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    /* This is the Decorator class essential to this Design pattern. It inherits from Property and us to change the Properties
     * during the game. All the Properties are "decorated" because they could be Free our Bought but not simple Properties.
     */
    class DecoratorProperty : Property
    {
        #region Attributes
        public Property decoratedProperty;
        #endregion

        #region Constructor
        public DecoratorProperty(Property decoratedProperty, Player p) //we need the player in order to get the owner.
        {
            this.name = decoratedProperty.name;
            this.buying_cost = decoratedProperty.buying_cost;
            this.type = decoratedProperty.type;
            this.owner = p;
            this.position = decoratedProperty.position;

        }
        #endregion

        #region Method 
        /* This method is essential to string the Properties that a player has bought.
         */
        public string toStringOwner()
        {
            return "\tName: " + name + "\n\tType: " + type.ToString() + "\n\tBuying cost: $" + buying_cost + "\n\tTaxes: $" + taxes +
                "\n\tSituation: " + situation.ToString() + "\n\tOwner: " + owner.name;
        }
        #endregion
    }

}
