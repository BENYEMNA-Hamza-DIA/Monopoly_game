using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    /* There is a mist of types that could have a Cell essential for our Factory pattern.
     */
    public enum CellType { Start, LuxuryTaxe, IncomeTaxe, Property, Jail, GoToJail, Chance, CommunityChest, FreeParking};
    public abstract class FactoryCell //This class is abstract because it is at the core of the creation of Cells.
    {
        public abstract Cell CreateCell(CellType type);
    }
}
