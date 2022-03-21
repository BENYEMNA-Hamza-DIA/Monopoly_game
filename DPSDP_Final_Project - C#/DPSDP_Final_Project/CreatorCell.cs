using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    /* This class is essential because it is the one the one that inherits from the FactoryCell class in order to create the Cells 
     * given a type that we need.
     */
    public class CreatorCell : FactoryCell
    {
        public CellType type;
        public override Cell CreateCell(CellType type) //the override is essential for this method.
        {
            switch (type)
            {
                case CellType.Start:
                    return new Start();


                case CellType.Chance:
                    return new Chance();

                case CellType.CommunityChest:
                    return new CommunityChest();

                case CellType.Jail:
                    return new Jail();

                case CellType.GoToJail:
                    return new GoToJail();

                case CellType.FreeParking:
                    return new FreeParking();

                case CellType.IncomeTaxe:
                    return new IncomeTaxe();

                case CellType.LuxuryTaxe:
                    return new LuxuryTaxe();


                default:
                    throw new CellTypeException("Cannot create a cell of the given type");
            }
        }
    }
}
