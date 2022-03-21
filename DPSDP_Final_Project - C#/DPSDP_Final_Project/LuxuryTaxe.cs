using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    // The player that arrives here paies a taxe.
    public sealed class LuxuryTaxe : Cell
    {
        #region Constructors
        public LuxuryTaxe() { }

        public LuxuryTaxe(int position) : base(position)
        {

        }
        #endregion

        #region Method
        public override string toString()
        {
            return "Luxury Taxe Cell";
        }
        #endregion
    }
}
