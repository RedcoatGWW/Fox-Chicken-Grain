namespace Fox_Chicken_Grain;

class Program
{
    static void Main(string[] args)
    {

        //Creates the new game instance
        CGame game = new CGame();
        //Displays the introduction and explains what the player needs to do (need to thin out the text)
        game.DisplayInstructions();
        //Waits for the player to press a button to start the game and clears the screen
        Console.ReadKey();
        Console.Clear();
       



        bool GameOver = false;
        while (!game.isWon() && !game.isLost())
        {
            //Displays the game
            game.DisplayBanks();

            //=============Moving from south bank============= 
            Console.WriteLine("What side would you like to move from?");
            Console.WriteLine("North or South?");
            string choice = Console.ReadLine();

            if (choice == "South")
            {
                Console.Clear();
                Console.WriteLine("What would you like to move?");

                string choice2 = Console.ReadLine();
                if (choice2 == "Chicken")
                {
                    game._south.RemoveFirst(CGame.Item.Chicken);
                    game._south.RemoveFirst(CGame.Item.Farmer);
                    game._north.Add(CGame.Item.Chicken);
                    game._north.Add(CGame.Item.Farmer);
                    Console.Clear();
                }

                else if (choice2 == "Fox")
                {
                    game._south.RemoveFirst(CGame.Item.Fox);
                    game._south.RemoveFirst(CGame.Item.Farmer);
                    game._north.Add(CGame.Item.Fox);
                    game._north.Add(CGame.Item.Farmer);
                    Console.Clear();
                }

                else if (choice2 == "Grain")
                {
                    game._south.RemoveFirst(CGame.Item.Grain);
                    game._south.RemoveFirst(CGame.Item.Farmer);
                    game._north.Add(CGame.Item.Grain);
                    game._north.Add(CGame.Item.Farmer);
                    Console.Clear();
                }
                else if (choice2 == "Farmer")
                {
                    game._south.RemoveFirst(CGame.Item.Farmer);
                    game._north.Add(CGame.Item.Farmer);
                    Console.Clear();
                }

                else
                {
                    Console.WriteLine("Bad input");
                }
            }

                //=============Moving fromm north bank=============    
            if (choice == "North")
                {
                Console.Clear();
                Console.WriteLine("What would you like to move?");
                string choice3 = Console.ReadLine();

                if (choice3 == "Chicken")
                {
                    game._north.RemoveFirst(CGame.Item.Chicken);
                    game._north.RemoveFirst(CGame.Item.Farmer);
                    game._south.Add(CGame.Item.Chicken);
                    game._south.Add(CGame.Item.Farmer);
                    Console.Clear();
                }

                else if (choice3 == "Fox")
                {
                    game._north.RemoveFirst(CGame.Item.Fox);
                    game._north.RemoveFirst(CGame.Item.Farmer);
                    game._south.Add(CGame.Item.Fox);
                    game._south.Add(CGame.Item.Farmer);
                    Console.Clear();
                }

                else if (choice3 == "Grain")
                {
                    game._north.RemoveFirst(CGame.Item.Grain);
                    game._north.RemoveFirst(CGame.Item.Farmer);
                    game._south.Add(CGame.Item.Grain);
                    game._south.Add(CGame.Item.Farmer);
                    Console.Clear();
                }
                else if (choice3 == "Farmer")
                {
                    game._north.RemoveFirst(CGame.Item.Farmer);
                    game._south.Add(CGame.Item.Farmer);
                    Console.Clear();
                }

                else
                {
                    Console.WriteLine("Bad input");
                }
                }
            }
        }
    }





//testing calling the items

// CGame.Item item1 = CGame.Item.Fox;
// CGame.Item item2 = CGame.Item.Chicken; 
// CGame.Item item3 = CGame.Item.Grain;
//
// Console.Write(item1);
// Console.Write(item2);
// Console.Write(item3);
