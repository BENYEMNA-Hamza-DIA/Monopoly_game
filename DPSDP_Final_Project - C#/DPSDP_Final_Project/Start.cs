using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    public sealed class Start : Cell
    {
        #region Constructor
        public Start() { }

        
        public Start(int position) : base(position)
        {

        }
        #endregion

        #region Method
        public override string toString()
        {
            return "Start Cell";
        }
        #endregion
    }
}
