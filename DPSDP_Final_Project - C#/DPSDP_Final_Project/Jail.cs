using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    //The player arrives their when he makes 3 double dice in a row or when he arrives at the Go To Jail Cell.
    public sealed class Jail : Cell
    {
        #region Constructors
        public Jail() { }

        public Jail(int position) : base(position)
        {

        }
        #endregion

        #region Method
        public override string toString()
        {
            return "Jail Cell";
        }
        #endregion
    }
}
