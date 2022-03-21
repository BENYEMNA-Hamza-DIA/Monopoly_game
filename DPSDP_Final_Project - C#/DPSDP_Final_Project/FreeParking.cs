using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    //This cell has no specification. The player is sure to not pay taxes.
    public sealed class FreeParking : Cell
    {
        #region Constructor
        public FreeParking() { }
        
        public FreeParking(int position) : base(position)
        {

        }
        #endregion

        #region Method
        public override string toString()
        {
            return "Free Parking Cell";
        }
        #endregion
    }
}
