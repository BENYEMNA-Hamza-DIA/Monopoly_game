using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    // It is a the position 30. The player that arrives to this Cell goes directly to the Jail.
    public sealed class GoToJail : Cell
    {
        #region Constructors
        public GoToJail() { }

        public GoToJail(int position) : base(position)
        {

        }
        #endregion

        #region Method
        public override string toString()
        {
            return "Go To Jail Cell";
        }
        #endregion
    }
}
