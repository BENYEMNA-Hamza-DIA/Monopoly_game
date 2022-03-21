using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    /* The board is created with a Singleton Design pattern. This is useful because we need only one board reusable during the whole game.
     */
    class SingletonBoard
    {
        #region Attributes
        private static SingletonBoard instance = null;
        public Cell[] board = new Cell[40];
        private static readonly object padlock = new object(); // This secure the creation of only one board.
        #endregion

        #region Constructor
        public SingletonBoard()
        {
            CreateBoard();
        }
        #endregion

        #region Instance
        public static SingletonBoard Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonBoard();
                    }
                    return instance;
                }
            }
        }
        #endregion

        #region Method
        public void CreateBoard()
        {
            //The board is composed of Cells that we create. To do so, we use our Factory Design Pattern.
            #region Factory Design Pattern : creation of the board cells
            CreatorCell cellcreator = new CreatorCell();

            #region Start
            Start start = (Start)cellcreator.CreateCell(CellType.Start);
            start.position = 0;
            #endregion

            #region Chance
            Chance chance2 = (Chance)cellcreator.CreateCell(CellType.Chance);
            chance2.position = 2;
            chance2.content_chance = 0;

            Chance chance22 = (Chance)cellcreator.CreateCell(CellType.Chance);
            chance22.position = 22;
            chance22.content_chance = 0;

            Chance chance33 = (Chance)cellcreator.CreateCell(CellType.Chance);
            chance33.position = 33;
            chance33.content_chance = 0;
            #endregion

            #region Community Chests
            CommunityChest communitychest7 = (CommunityChest)cellcreator.CreateCell(CellType.CommunityChest);
            communitychest7.position = 7;
            communitychest7.taxe_cc = 0;

            CommunityChest communitychest17 = (CommunityChest)cellcreator.CreateCell(CellType.CommunityChest);
            communitychest17.position = 17;
            communitychest17.taxe_cc = 0;

            CommunityChest communitychest36 = (CommunityChest)cellcreator.CreateCell(CellType.CommunityChest);
            communitychest36.position = 36;
            communitychest36.taxe_cc = 0;
            #endregion

            #region Income taxe
            IncomeTaxe incometaxe = (IncomeTaxe)cellcreator.CreateCell(CellType.IncomeTaxe);
            incometaxe.position = 4;
            #endregion

            #region Jail
            Jail jail = (Jail)cellcreator.CreateCell(CellType.Jail);
            jail.position = 10;
            #endregion

            #region Free parking
            FreeParking freeparking = (FreeParking)cellcreator.CreateCell(CellType.FreeParking);
            freeparking.position = 20;
            #endregion

            #region Go To Jail
            GoToJail gotojail = (GoToJail)cellcreator.CreateCell(CellType.GoToJail);
            gotojail.position = 30;
            #endregion

            #region Luxury Taxe
            LuxuryTaxe luxurytaxe = (LuxuryTaxe)cellcreator.CreateCell(CellType.LuxuryTaxe);
            luxurytaxe.position = 38;

            #endregion

            #region Propreties
            DecoratorProperty dp1 = new FreeProperty(new Property(1, "Mediterranean Avenue", Type_Property.House, 60, 0, Property_Situation.Free, null),null);
            Property property1 = new Property(1,"Mediterranean Avenue", Type_Property.House, 60, 0, Property_Situation.Free, null);

            DecoratorProperty dp3 = new FreeProperty(new Property(3, "Baltic Avenue", Type_Property.House, 60, 0, Property_Situation.Free, null), null);
            Property property3 = new Property(3, "Baltic Avenue", Type_Property.House, 60, 0, Property_Situation.Free, null);

            DecoratorProperty dp5 = new FreeProperty(new Property(5, "Reading Railroad", Type_Property.Train_Station, 200, 0, Property_Situation.Free, null), null);
            Property property5 = new Property(5, "Reading Railroad", Type_Property.Train_Station, 200, 0, Property_Situation.Free, null);

            DecoratorProperty dp6 = new FreeProperty(new Property(6, "Oriental Avenue", Type_Property.House, 100, 0, Property_Situation.Free, null), null);
            Property property6 = new Property(6, "Oriental Avenue", Type_Property.House, 100, 0, Property_Situation.Free, null);

            DecoratorProperty dp8 = new FreeProperty(new Property(8, "Vermont Avenue", Type_Property.House, 100, 0, Property_Situation.Free, null), null);
            Property property8 = new Property(8, "Vermont Avenue", Type_Property.House, 100, 0, Property_Situation.Free, null);

            DecoratorProperty dp9 = new FreeProperty(new Property(9, "Connecticut Avenue", Type_Property.House, 120, 0, Property_Situation.Free, null), null);
            Property property9 = new Property(9, "Connecticut Avenue", Type_Property.House, 120, 0, Property_Situation.Free, null);

            DecoratorProperty dp11 = new FreeProperty(new Property(11, "St. Charles Place", Type_Property.House, 140, 0, Property_Situation.Free, null), null);
            Property property11 = new Property(11, "St. Charles Place", Type_Property.House, 140, 0, Property_Situation.Free, null);

            DecoratorProperty dp12 = new FreeProperty(new Property(12, "Electric Company", Type_Property.Service, 150, 0, Property_Situation.Free, null), null);
            Property property12 = new Property(12, "Electric Company", Type_Property.Service, 150, 0, Property_Situation.Free, null);

            DecoratorProperty dp13 = new FreeProperty(new Property(13, "States Avenue", Type_Property.House, 140, 0, Property_Situation.Free, null), null);
            Property property13 = new Property(13, "States Avenue", Type_Property.House, 140, 0, Property_Situation.Free, null);

            DecoratorProperty dp14 = new FreeProperty(new Property(14, "Virginia Avenue", Type_Property.House, 160, 0, Property_Situation.Free, null), null);
            Property property14 = new Property(14, "Virginia Avenue", Type_Property.House, 160, 0, Property_Situation.Free, null);

            DecoratorProperty dp15 = new FreeProperty(new Property(15, "Pennsylvania Railroad", Type_Property.Train_Station, 200, 0, Property_Situation.Free, null), null);
            Property property15 = new Property(15, "Pennsylvania Railroad", Type_Property.Train_Station, 200, 0, Property_Situation.Free, null);

            DecoratorProperty dp16 = new FreeProperty(new Property(16, "St. James Place", Type_Property.House, 180, 0, Property_Situation.Free, null), null);
            Property property16 = new Property(16, "St. James Place", Type_Property.House, 180, 0, Property_Situation.Free, null);

            DecoratorProperty dp18 = new FreeProperty(new Property(18, "Tennessee Avenue", Type_Property.House, 180, 0, Property_Situation.Free, null), null);
            Property property18 = new Property(18, "Tennessee Avenue", Type_Property.House, 180, 0, Property_Situation.Free, null);

            DecoratorProperty dp19 = new FreeProperty(new Property(19, "New York Avenue", Type_Property.House, 200, 0, Property_Situation.Free, null), null);
            Property property19 = new Property(19, "New York Avenue", Type_Property.House, 200, 0, Property_Situation.Free, null);

            DecoratorProperty dp21 = new FreeProperty(new Property(21, "Kentucky Avenue", Type_Property.House, 220, 0, Property_Situation.Free, null), null);
            Property property21 = new Property(21, "Kentucky Avenue", Type_Property.House, 220, 0, Property_Situation.Free, null);

            DecoratorProperty dp23 = new FreeProperty(new Property(23, "Indiana Avenue", Type_Property.House, 220, 0, Property_Situation.Free, null), null);
            Property property23 = new Property(23, "Indiana Avenue", Type_Property.House, 220, 0, Property_Situation.Free, null);

            DecoratorProperty dp24 = new FreeProperty(new Property(24, "Illinois Avenue", Type_Property.House, 240, 0, Property_Situation.Free, null), null);
            Property property24 = new Property(24, "Illinois Avenue", Type_Property.House, 240, 0, Property_Situation.Free, null);

            DecoratorProperty dp25 = new FreeProperty(new Property(25, "B. & O. Railroad", Type_Property.Train_Station, 200, 0, Property_Situation.Free, null), null);
            Property property25 = new Property(25, "B. & O. Railroad", Type_Property.Train_Station, 200, 0, Property_Situation.Free, null);

            DecoratorProperty dp26 = new FreeProperty(new Property(26, "Atlantic Avenue", Type_Property.House, 260, 0, Property_Situation.Free, null), null);
            Property property26 = new Property(26, "Atlantic Avenue", Type_Property.House, 260, 0, Property_Situation.Free, null);

            DecoratorProperty dp27 = new FreeProperty(new Property(27, "Ventnor Avenue", Type_Property.House, 260, 0, Property_Situation.Free, null), null);
            Property property27 = new Property(27, "Ventnor Avenue", Type_Property.House, 260, 0, Property_Situation.Free, null);

            DecoratorProperty dp28 = new FreeProperty(new Property(28, "Water Works", Type_Property.Service, 150, 0, Property_Situation.Free, null), null);
            Property property28 = new Property(28, "Water Works", Type_Property.Service, 150, 0, Property_Situation.Free, null);

            DecoratorProperty dp29 = new FreeProperty(new Property(29, "Marvin Gardens", Type_Property.House, 280, 0, Property_Situation.Free, null), null);
            Property property29 = new Property(29, "Marvin Gardens", Type_Property.House, 280, 0, Property_Situation.Free, null);

            DecoratorProperty dp31 = new FreeProperty(new Property(31, "Pacific Avenue", Type_Property.House, 300, 0, Property_Situation.Free, null), null);
            Property property31 = new Property(31, "Pacific Avenue", Type_Property.House, 300, 0, Property_Situation.Free, null);

            DecoratorProperty dp32 = new FreeProperty(new Property(32, "North Carolina Avenue", Type_Property.House, 300, 0, Property_Situation.Free, null), null);
            Property property32 = new Property(32, "North Carolina Avenue", Type_Property.House, 300, 0, Property_Situation.Free, null);

            DecoratorProperty dp34 = new FreeProperty(new Property(34, "Pennsylvania Avenue", Type_Property.House, 320, 0, Property_Situation.Free, null), null);
            Property property34 = new Property(34, "Pennsylvania Avenue", Type_Property.House, 320, 0, Property_Situation.Free, null);

            DecoratorProperty dp35 = new FreeProperty(new Property(35, "Short Line", Type_Property.Train_Station, 200, 0, Property_Situation.Free, null), null);
            Property property35 = new Property(35, "Short Line", Type_Property.Train_Station, 200, 0, Property_Situation.Free, null);

            DecoratorProperty dp37 = new FreeProperty(new Property(37, "Park Place", Type_Property.House, 350, 0, Property_Situation.Free, null), null);
            Property property37 = new Property(37, "Park Place", Type_Property.House, 350, 0, Property_Situation.Free, null);

            DecoratorProperty dp39 = new FreeProperty(new Property(39, "Boardwalk", Type_Property.House, 400, 0, Property_Situation.Free, null), null);
            Property property39 = new Property(39, "Boardwalk", Type_Property.House, 400, 0, Property_Situation.Free, null);



            #endregion

            #endregion

            board[0] = start;// start: collect $200 as you pass
            board[1] = property1;
            board[2] = chance2;
            board[3] = property3;
            board[4] = incometaxe; // income tax (pay $200)
            board[5] = property5;
            board[6] = property6;
            board[7] = communitychest7;
            board[8] = property8;
            board[9] = property9;
            board[10] = jail; //jail
            board[11] = property11;
            board[12] = property12;
            board[13] = property13;
            board[14] = property14;
            board[15] = property15;
            board[16] = property16;
            board[17] = communitychest17;
            board[18] = property18;
            board[19] = property19;
            board[20] = freeparking; // free parking
            board[21] = property21;
            board[22] = chance22;
            board[23] = property23;
            board[24] = property24;
            board[25] = property25;
            board[26] = property26;
            board[27] = property27;
            board[28] = property28;
            board[29] = property29;
            board[30] = gotojail; // go to jail
            board[31] = property31;
            board[32] = property32;
            board[33] = chance33;
            board[34] = property34;
            board[35] = property35;
            board[36] = communitychest36;
            board[37] = property37;
            board[38] = luxurytaxe; // luxury tax (pay $100)
            board[39] = property39;
        }
        #endregion
    }
}
