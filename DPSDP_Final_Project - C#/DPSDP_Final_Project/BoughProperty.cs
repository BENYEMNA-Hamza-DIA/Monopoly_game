using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    /* This class is a concrete object produced by the Decorator Design pattern used to create Properties.
     * This allow us to change the situation of a property in a dynamic way during the game when a player by it.
     * Indeed, a free property becomes a Boughproperty.
     */
    class BoughtProperty : DecoratorProperty
    {
        #region Constructor
        public BoughtProperty(Property decoratedProperty, Player p) : base(decoratedProperty, p)
        {
            this.taxes = decoratedProperty.buying_cost / 5;
            this.situation = Property_Situation.Bought;
        }
        #endregion

    }
}
