using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    //The player that arrives at this Cell has to pay taxes.
    public sealed class IncomeTaxe : Cell
    {
        #region Constructors
        public IncomeTaxe() { }

        public IncomeTaxe(int position) : base(position)
        {

        }
        #endregion

        #region Method
        public override string toString()
        {
            return "Income Taxe Cell";
        }
        #endregion

    }
}
