using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    /* The Comminuty chest class is similar to Chance but in all cases, we pay a tax that is randomized from 10 to 500$.
     */
    public sealed class CommunityChest : Cell
    {
        #region Attributes
        public double taxe_cc;
        #endregion

        #region Constructors
        public CommunityChest() { }

        public CommunityChest(int position, double taxe_cc) : base(position)
        {
            this.taxe_cc = RandomTaxe();

        }
        #endregion

        #region Methods
        public double RandomTaxe()
        {
            Random rnd = new Random();
            double result = rnd.Next(10, 500);
            return result;
        }
        #endregion

    }
}
