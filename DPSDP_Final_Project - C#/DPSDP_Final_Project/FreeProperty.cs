using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    /* As explained for the BoughtProperties, it is the same for the Free one.
     */
    class FreeProperty : DecoratorProperty
    {

        public FreeProperty(Property decoratedProperty, Player p) : base(decoratedProperty, p)
        {

            
        }

    }
}
