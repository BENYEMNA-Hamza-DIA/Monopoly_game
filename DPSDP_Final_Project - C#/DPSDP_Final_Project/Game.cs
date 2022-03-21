using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    //This is the main class of this project. All is settled in it.
    class Game
    {
        #region Attributes
        public List<Player> players = new List<Player>(); // who is playing.
        public SingletonBoard board_game = new SingletonBoard();
        public int rounds; // number of rounds played.
        public Player winner;
        #endregion

        #region Constructor
        public Game() { }
        #endregion

        #region Test Cases

        #region Double Dice
        public void StartDoubleDice(List<Player> players)
        {

            Player winner = new Player();

            Console.Clear();
            Console.WriteLine("The game is starting !");
            while (Winner() != true)
            {
                Console.Clear();

                this.rounds++;

                foreach (Player p in players)
                {
                    int[] dices = new int[2];
                    int nbdouble = 0;
                    if (p.jail)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPlayer in game: " + p.Name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nPress any key to roll the dices !\n");
                        Console.ReadKey(true);

                        dices = p.RollDices();
                        Console.ForegroundColor = ConsoleColor.Green;

                        if (p.DoubleBool(dices))
                        {
                            nbdouble++;
                            p.Move(dices[0] + dices[1]);
                            Console.WriteLine("\nCongratulation! You're free!");
                            Console.WriteLine("\nCurrent position :" + p.position + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey(true);
                            DisplayMenu(players, p, true);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you have to make a double to be free.");
                            Console.ReadKey(true);
                            break;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nPlayer " + p.Name + ":");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress any key to roll the dices !\n");
                    Console.ReadKey(true);
                    dices[0] = 4;
                    dices[1] = 4;
                    Console.ForegroundColor = ConsoleColor.Green;
                    p.Move(dices[0] + dices[1]);
                    Console.WriteLine("\nCurrent position :" + p.position + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey(true);
                    DisplayMenu(players, p, true);
                    while (p.DoubleBool(dices))
                    {
                        nbdouble++;
                        if (nbdouble == 3)
                        {
                            Console.WriteLine("You rolled a double for the third time in a row. You must go to jail.");
                            p.jail = true;
                            p.position = 10;
                            Console.WriteLine("You are now in jail.\n");
                            Console.ReadKey(true);
                            break;
                        }
                        Console.WriteLine("\nWow, you got a double, you can roll the dices again !");
                        Console.WriteLine("\nPress any key to roll the dices !\n");
                        Console.ReadKey(true);
                        dices = p.RollDices();
                        p.Move(dices[0] + dices[1]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nCurrent position :" + p.position + "\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey(true);
                        Environment.Exit(0);

                    }

                }
            }
            this.winner = players[0];
            Console.WriteLine("La partie a durée :" + this.rounds);
            Console.WriteLine("Gagnant :" + this.winner.Name);
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        #endregion

        #region Triple Dice + Go To Jail
        public void StartTripleDice(List<Player> players)
        {

            Player winner = new Player();

            Console.Clear();
            Console.WriteLine("The game is starting !");
            while (Winner() != true)
            {
                Console.Clear();

                this.rounds++;

                foreach (Player p in players)
                {
                    int[] dices = new int[2];
                    int nbdouble = 0;
                    if (p.jail)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPlayer in game: " + p.Name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nPress any key to roll the dices !\n");
                        Console.ReadKey(true);

                        dices = p.RollDices();
                        Console.ForegroundColor = ConsoleColor.Green;

                        if (p.DoubleBool(dices))
                        {
                            nbdouble++;
                            p.Move(dices[0] + dices[1]);
                            Console.WriteLine("\nCongratulation! You're free!");
                            Console.WriteLine("\nCurrent position :" + p.position + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey(true);
                            DisplayMenu(players, p, true);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you have to make a double to be free.");
                            Console.ReadKey(true);
                            break;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nPlayer " + p.Name + ":");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress any key to roll the dices !\n");
                    Console.ReadKey(true);
                    dices[0] = 4;
                    dices[1] = 4;
                    Console.ForegroundColor = ConsoleColor.Green;
                    p.Move(dices[0] + dices[1]);
                    Console.WriteLine("\nCurrent position :" + p.position + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey(true);
                    DisplayMenu(players, p, true);
                    while (p.DoubleBool(dices))
                    {
                        nbdouble++;
                        if (nbdouble == 3)
                        {
                            Console.WriteLine("You rolled a double for the third time in a row. You must go to jail.");
                            p.jail = true;
                            p.position = 10;
                            Console.WriteLine("You are now in jail.\n");
                            Console.WriteLine("Position of player " + p.name + " is : " + p.position);
                            Console.ReadKey(true);
                            Environment.Exit(0);
                        }
                        Console.WriteLine("\nWow, you got a double, you can roll the dices again !");
                        Console.WriteLine("\nPress any key to roll the dices !\n");
                        Console.ReadKey(true);
                        dices[0] = 4;
                        dices[1] = 4;
                        p.Move(dices[0] + dices[1]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nCurrent position :" + p.position + "\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey(true);
                        DisplayMenu(players, p, true);

                    }

                }
            }
            this.winner = players[0];
            Console.WriteLine("La partie a durée :" + this.rounds);
            Console.WriteLine("Gagnant :" + this.winner.Name);
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        #endregion

        #region Buy a property
        public void StartBuyProperty(List<Player> players)
        {


            Player winner = new Player();

            Console.Clear();
            Console.WriteLine("The game is starting !");
            while (Winner() != true)
            {
                Console.Clear();

                this.rounds++;

                foreach (Player p in players)
                {
                    int[] dices = new int[2];
                    int nbdouble = 0;
                    if (p.jail)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPlayer in game: " + p.Name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nPress any key to roll the dices !\n");
                        Console.ReadKey(true);

                        dices = p.RollDices();
                        Console.ForegroundColor = ConsoleColor.Green;

                        if (p.DoubleBool(dices))
                        {
                            nbdouble++;
                            p.Move(dices[0] + dices[1]);
                            Console.WriteLine("\nCongratulation! You're free!");
                            Console.WriteLine("\nCurrent position :" + p.position + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey(true);
                            DisplayMenu(players, p, true);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you have to make a double to be free.");
                            Console.ReadKey(true);
                            break;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nPlayer " + p.Name + ":");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress any key to roll the dices !\n");
                    Console.ReadKey(true);
                    dices[0] = 4;
                    dices[1] = 4;
                    Console.ForegroundColor = ConsoleColor.Green;
                    p.Move(dices[0] + dices[1]);
                    Console.WriteLine("\nCurrent position :" + p.position + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please purchase the property for the test.");
                    Console.ReadKey(true);
                    DisplayMenu(players, p, true);
                    while (p.DoubleBool(dices))
                    {
                        nbdouble++;
                        if (nbdouble == 3)
                        {
                            Console.WriteLine("You rolled a double for the third time in a row. You must go to jail.");
                            p.jail = true;
                            p.position = 10;
                            Console.WriteLine("You are now in jail.\n");
                            Console.ReadKey(true);
                            break;
                        }
                        Console.WriteLine("\nWow, you got a double, you can roll the dices again !");
                        Console.WriteLine("\nPress any key to roll the dices !\n");
                        Console.ReadKey(true);
                        dices = p.RollDices();
                        p.Move(dices[0] + dices[1]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nCurrent position :" + p.position + "\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey(true);
                        DisplayMenu(players, p, true);
                    }

                }
            }
            this.winner = players[0];
            Console.WriteLine("La partie a durée :" + this.rounds);
            Console.WriteLine("Gagnant :" + this.winner.Name);
            Console.ReadKey(true);
            Environment.Exit(0);
        }


        #endregion

        #endregion

        #region Methods
        //This method is used to verify if their is a winner during the game in order to end the party.
        public bool Winner()
        {
            bool win = false;

            foreach(Player p in this.players)
            {
                if(p.loser)
                {
                    this.players.Remove(p);
                }
            }
            if(this.players.Count==1)
            {
                win = true;
            }

            return win;
        }

        //This method is used to create a game with a number of players between 2 and 6.
        public List<Player> Create()
        {
            List<Player> players = new List<Player>();

            Console.WriteLine("Welcome! Let's play Monopoly.");
            int nbpl = 0;
            while (nbpl !=2 && nbpl != 3 && nbpl != 4 && nbpl != 5 && nbpl != 6)
            {
                Console.WriteLine("\nEnter how many players during this game (2-6):");
                nbpl = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < nbpl; i++)
            {
                Console.WriteLine("\nPlayer n" + (i + 1) + " : ");
                Console.Write("Please enter a username : ");
                string name = Console.ReadLine();
                
                Player p = new Player(name);
                players.Add(p);
                Console.WriteLine("\nThe player " + p.name + " was successfully added!");
            }
            Console.WriteLine("\nPlayers:");

            foreach (Player p in players)
            {
                Console.WriteLine("\n"+p.toString());
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPress any key to start the game :\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            
            return players;
        }

        //This is the main method that rue the entire game.
        public void Start(List<Player> players)
        {

            Player winner = new Player();

            Console.Clear();
            Console.WriteLine("The game is starting !");
            while (Winner()!=true)
            {
                Console.Clear();

                this.rounds++;
                
                foreach (Player p in players)
                {
                    int[] dices = new int[2];
                    int nbdouble = 0;
                    if (p.jail)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPlayer in game: " + p.Name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nPress any key to roll the dices !\n");
                        Console.ReadKey(true);

                        dices = p.RollDices();

                        Console.ForegroundColor = ConsoleColor.Green;

                        if (p.DoubleBool(dices))
                        {
                            nbdouble++;
                            p.Move(dices[0] + dices[1]);
                            Console.WriteLine("\nCongratulation! You're free!");
                            Console.WriteLine("\nCurrent position :" + p.position + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey(true);
                            DisplayMenu(players, p, true);
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you have to make a double to be free.");
                            Console.ReadKey(true);
                            break;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nPlayer " + p.Name + ":");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPress any key to roll the dices !\n");
                    Console.ReadKey(true);

                    dices = p.RollDices();

                    Console.ForegroundColor = ConsoleColor.Green;
                    p.Move(dices[0] + dices[1]);
                    Console.WriteLine("\nCurrent position :" + p.position + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey(true);
                    DisplayMenu(players, p, true);
                    while (p.DoubleBool(dices))
                    {
                        nbdouble++;
                        if (nbdouble == 3) //to not let the player play his 3rd turn.
                        {
                            Console.WriteLine("You rolled a double for the third time in a row. You must go to jail.");
                            p.jail = true;
                            p.position = 10;
                            Console.WriteLine("You are now in jail.\n");
                            Console.ReadKey(true);
                            break;
                        }
                        Console.WriteLine("\nWow, you got a double, you can roll the dices again !");
                        Console.WriteLine("\nPress any key to roll the dices !\n");
                        Console.ReadKey(true);
                        dices = p.RollDices();
                        p.Move(dices[0] + dices[1]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nCurrent position :" + p.position + "\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey(true);
                        DisplayMenu(players, p, true);
                    }

                }
            }
            this.winner = players[0];
            Console.WriteLine("\nThe game lasted " + this.rounds + " turns.");
            Console.WriteLine("\nCongralutions to the winner " + this.winner.Name + "! Well Played :) ");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        /*A MenuDisplay helps us to have an interface to play. This allow us to have a dashboard, a game status, purchase Properties
         * when it is possible and to exit the game whenever we want.
        */
        public void DisplayMenu(List<Player> players, Player player, bool pos)
        {
            List<int> position_properties = new List<int> { 1, 3, 5, 6, 8, 9, 11, 12, 13, 14, 15, 16, 18, 19, 21, 23, 24, 25, 26, 27, 28, 29, 31, 32, 34, 35, 37, 39 };
            
            Console.Clear();

            if (pos)
            {
                DisplayPosition(player);
            }
            int resp = -1;
            while(resp!=0 && resp != 1 && resp != 2 && resp != 3 && resp != 4)
            {
                if(position_properties.Contains(player.position)==true)
                {
                    Console.WriteLine("\nPlease Make a Selection :\n");
                    Console.WriteLine("0 : Game Status");
                    Console.WriteLine("1 : Finish Turn");
                    Console.WriteLine("2 : Your DashBoard");
                    Console.WriteLine("3 : Purchase the property");
                    Console.WriteLine("4 : Quit Game");
                    Console.Write("Your choice: ");
                    resp = int.Parse(Console.ReadLine());

                    switch (resp)
                    {

                        case 0:
                            Console.Clear();
                            Console.WriteLine("\nGame Status :");
                            foreach (Player p in players)
                            {
                                Console.WriteLine(p.toString());
                            }
                            Console.ReadKey();
                            DisplayMenu(players, player, pos);
                            break;
                        case 1:
                            Console.Clear();
                            break;
                        case 2:
                            Dashboard(player);
                            break;
                        case 3:
                            PurchaseProperty(player);
                            break;
                        case 4:
                            int entry = 0;
                            player.loser = true;
                            Winner();
                            Console.Clear();
                            Console.WriteLine("\nDo you really want to exit the game ? \n");
                            while (entry != 1 && entry != 2)
                            {
                                Console.WriteLine("1 : YES\n2 : NO");
                                entry = int.Parse(Console.ReadLine());
                                if(entry==1)
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    DisplayMenu(players, player, true);
                                }
                            }
                            
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("\nPlease Make a Selection :\n");
                    Console.WriteLine("0 : Game Status");
                    Console.WriteLine("1 : Finish Turn");
                    Console.WriteLine("2 : Your DashBoard");
                    Console.WriteLine("3 : Quit Game");
                    Console.Write("Your choice: ");
                    resp = int.Parse(Console.ReadLine());

                    switch (resp)
                    {

                        case 0:
                            Console.Clear();
                            Console.WriteLine("\nGame Status :");
                            foreach (Player p in players)
                            {
                                Console.WriteLine(p.toString());
                            }
                            Console.ReadKey();
                            DisplayMenu(players, player, pos);
                            break;
                        case 1:
                            Console.Clear();
                            break;
                        case 2:
                            Dashboard(player);
                            break;
                        case 3:
                            int entry = 0;
                            player.loser = true;
                            Winner();
                            Console.Clear();
                            Console.WriteLine("\nDo you really want to exit the game ? \n");
                            while (entry != 1 && entry != 2)
                            {
                                Console.WriteLine("1 : YES\n2 : NO");
                                entry = int.Parse(Console.ReadLine());
                            }
                            Environment.Exit(0);
                            break;

                    }
                }

            }

        }

        public void DisplayPosition(Player player)
        {
            Property p = new Property(0,"", Type_Property.House, 0, 0, Property_Situation.Free, null);
            BoughtProperty bp = new BoughtProperty(p,null);
            Chance c = new Chance();
            CommunityChest cc = new CommunityChest();

            Console.WriteLine("\nPlayer in game: " + player.Name);
            Console.WriteLine("\nThe cell you are currently on is the following:");

            if (board_game.board[player.position].GetType() == p.GetType())
            {
                p = (Property)board_game.board[player.position];
                Console.WriteLine(p.toString());
            }
            else if (board_game.board[player.position].GetType() == bp.GetType())
            {
                bp = (BoughtProperty)board_game.board[player.position];
                Console.WriteLine(bp.toStringOwner());
                if (bp.owner != player)
                {
                    Console.WriteLine("\nYou must pay $" + bp.taxes + " to " + bp.owner.name);
                    if (player.money < bp.taxes)
                    {
                        Console.WriteLine("\nYou do not have enough money. You lost.");
                        player.loser = true;
                        player.money = 0;
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(players, player, false);
                    }
                    else
                    {
                        player.money -= bp.taxes;
                        bp.owner.money += bp.taxes;
                        Console.WriteLine("\nYou now have $" + player.money);
                        Console.WriteLine("\n"+bp.owner.name +" now has $" + bp.owner.money);
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(players, player, false);
                    }
                }
               
            }

            else if (board_game.board[player.position].GetType() == c.GetType())
            {
                c = (Chance)board_game.board[player.position];
                Console.WriteLine("\nThis is the Chance!");
                ChanceCell(c, player);
                DisplayMenu(players, player, false);
            }
            else if (board_game.board[player.position].GetType() == cc.GetType())
            {
                cc = (CommunityChest)board_game.board[player.position];
                Console.WriteLine("This is the Community Chest!");
                CommunityChestCell(cc, player);
                DisplayMenu(players, player, false);
            }
            else
            {
                OtherCell(player);
            }

        }

        public void ChanceCell(Chance c, Player player)
        {
            Console.Clear();
            Console.Write("The Chance card is :");
            double rand_cash = c.RandomCash();
            Console.WriteLine("'" + c.Instruction(c.content_chance, rand_cash) + "'");
            
            if (c.content_chance == 1)
            {
                if (player.money < rand_cash)
                {
                    Console.WriteLine("You do not have enough money to pay. You lost.");
                    player.loser = true;
                    players.Remove(player);

                }
                else
                {
                    player.money -= rand_cash;
                    Console.WriteLine("You have paid $" + rand_cash + " for taxes.");
                    Console.WriteLine("You now have $" + player.money);
                }
            }
            else
            {
                player.money += rand_cash;
                Console.WriteLine("You have received $" + rand_cash + " from the bank.");
                Console.WriteLine("You now have $" + player.money);
            }
            
            Console.WriteLine("\nPress any key to go back to the menu.");
            Console.ReadKey(true);
        }

        public void CommunityChestCell(CommunityChest cc, Player player)
        {
            Console.Clear();
            Console.Write("The Community Chests card is :");
            double rand_taxe = cc.RandomTaxe();
            
            if (player.money < rand_taxe)
            {
                Console.WriteLine("You do not have enough money to pay. You lost.");
                player.loser = true;

            }
            else
            {
                player.money -= rand_taxe;
                Console.WriteLine("You have paid $" + rand_taxe + " for community chest taxes.");
                Console.WriteLine("You now have $" + player.money);
            }

            Console.WriteLine("\nPress any key to go back to the menu.");
            Console.ReadKey(true);
        }

        public void OtherCell(Player player)
        {
            Console.Clear();
            if (player.position == 0)
            {
                Console.WriteLine("\nThis is the Start!");
            }
            else if (player.position == 4)
            {
                Console.WriteLine("Income taxes!\nYou have to pay $200.");
                if (player.money < 200)
                {
                    Console.WriteLine("\nYou do not have enough money. You lost.");
                    player.loser = true;
                    Console.WriteLine("\nPress any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(players, player, false);
                }
                else
                {
                    player.money -= 200;
                    Console.WriteLine("You now have $" + player.money);
                    Console.WriteLine("\nPress any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(players, player, false);
                }
            }
            else if (player.position == 10)
            {
                Console.WriteLine("\nThis is the Jail! But don't worry you are only visiting.");
                Console.ReadKey(true);
                DisplayMenu(players, player, false);
            }
            else if (player.position == 20)
            {
                Console.WriteLine("\nFree parking!");
                Console.ReadKey(true);
                DisplayMenu(players, player, false);
            }
            else if (player.position == 30)
            {
                Console.WriteLine("\nGo to jail!");
                player.jail = true;
                player.position = 10;
                Console.WriteLine("You are now in jail.");
                Console.WriteLine("\nPress any key to go back to the menu.");
                Console.ReadKey(true);
                DisplayMenu(players, player, false);
            }
            else if (player.position == 38)
            {
                Console.WriteLine("Luxury taxes!\nYou have to pay $100.");
                if (player.money < 100)
                {
                    Console.WriteLine("\nYou do not have enough money. You lost.");
                    player.loser = true;
                    Console.WriteLine("\nPress any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(players, player, false);
                }
                else
                {
                    player.money -= 100;
                    Console.WriteLine("You now have $" + player.money);
                    Console.WriteLine("\nPress any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(players, player, false);
                }
            }
            else if (player.position == 7 || player.position == 17 || player.position == 36)
            {
                Console.WriteLine("Luxury taxes!\nYou have to pay $100.");
                if (player.money < 500)
                {
                    Console.WriteLine("\nYou do not have enough money. You lost.");
                    player.loser = true;
                    Console.WriteLine("\nPress any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(players, player, false);
                }
                else
                {
                    player.money -= 500;
                    Console.WriteLine("You now have $" + player.money);
                    Console.WriteLine("\nPress any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(players, player, false);
                }
            }
        }

        public void PurchaseProperty(Player player)
        {
            Property p = new Property(0,"", Type_Property.House, 0, 0, Property_Situation.Free, null);
            BoughtProperty bp = new BoughtProperty(p,null);
            if (board_game.board[player.position].GetType() == bp.GetType())
            {
                Console.WriteLine("This property is not available.");
                Console.WriteLine("Press any key to go back to the menu.");
                Console.ReadKey(true);
                DisplayMenu(players, player, true);
            }
            else if (board_game.board[player.position].GetType() == p.GetType())
            {
                Console.Clear();
                Console.WriteLine("The property you want to buy is the following:\n");
                p = (Property)board_game.board[player.position];
                Console.WriteLine(p.toString());
                if (p.buying_cost > player.money)
                {
                    Console.WriteLine("\nYou do not have enough money to go through with this purchase.");
                    Console.WriteLine("Press any key to go back to the menu.");
                    Console.ReadKey(true);
                    DisplayMenu(players, player, true);
                }
                else
                {
                    Console.WriteLine("\nYou currently have: $" + player.money);
                    int res = 0;
                    while (res != 1 && res != 2)
                    {
                        Console.WriteLine("Are you sure you want to go throught with this purchase?\n1 : YES\n2 : NO");
                        res = int.Parse(Console.ReadLine());
                    }
                    if (res == 1)
                    {
                        Console.Clear();
                        p = new BoughtProperty(p,null);
                        BoughtProperty b = (BoughtProperty)p;
                        board_game.board[player.position] = b;
                        p.owner = player;
                        player.properties.Add(b);
                        player.money -= p.buying_cost;
                        Console.WriteLine("\nCongratulations on your new property!");
                        Console.WriteLine(b.toStringOwner());
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(players, player, true);
                    }
                    else if (res == 2)
                    {
                        Console.WriteLine("\nPress any key to go back to the menu.");
                        Console.ReadKey(true);
                        DisplayMenu(players, player, true);
                    }
                }
            }
            else
            {
                Console.WriteLine("This cell is not a property, you cannot purchase it.");
                Console.WriteLine("\nPress any key to choose another action.\n");
                Console.ReadKey(true);
                DisplayMenu(players, player, true);
            }
        }

        public void Dashboard(Player player)
        {
            Console.Clear();
            Console.WriteLine("Your position is: " + player.position);
            Console.WriteLine("You have: $" + player.money);
            Console.WriteLine("You own " + player.properties.Count() + " properties:\n");
            if (player.properties.Count() != 0)
            {
                foreach (Property p in player.properties)
                {

                    Console.WriteLine("\n"+p.toString());
                }
            }
            Console.WriteLine("\nPress any key to go back to the menu.");
            Console.ReadKey(true);
            DisplayMenu(players, player, true);
        }

        #endregion


    }
}
