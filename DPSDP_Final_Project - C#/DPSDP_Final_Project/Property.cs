using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    /* The lists below helps us to define the type and situation of a Property used in ou Decorator pattern.
     */
    public enum Type_Property { Train_Station, Service, House }
    public enum Property_Situation { Free, Bought }
    class Property : Cell
    {
        #region Attributes
        public string name;
        public Type_Property type; // type of property: services, train station or house.
        public double buying_cost; // what the property costs if a player wants to buy it.
        public double taxes; // what the players who do not own the property will have to pay the owner if they land on it.
        public Property_Situation situation; // is the property free, bought.
        public Player owner; // the owner of the property, if it has been bought
        #endregion

        #region Constructors
        public Property() { }

        public Property(int position, string Name, Type_Property Type, double Buying_cost, double Taxes, Property_Situation Situation, Player Owner) : base(position)
        {
            this.name = Name;
            this.type = Type;
            this.buying_cost = Buying_cost;
            this.taxes = Taxes;
            this.situation = Situation;
            this.owner = Owner;

        }
        #endregion

        #region Proprieties
        public string Name { get => name; set => name = value; }
        public Type_Property Type { get => type; set => type = value; }
        public double Buying_cost { get => buying_cost; set => buying_cost = value; }
        public double Taxes { get => taxes; set => taxes = value; }
        public Property_Situation Situation { get => situation; set => situation = value; }
        public Player Owner { get => owner; set => owner = value; }
        #endregion

        #region Methods
        public override string toString()
        {
            return "\tName: " + name + "\n\tType: " + type.ToString() + "\n\tBuying cost: $" + buying_cost + "\n\tTaxes: $" + taxes +
                "\n\tSituation: " + situation.ToString();
        }
        #endregion
    }
}
