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
        //Displays the game
        game.DisplayBanks();
        
    



    bool GameOver = true;
    while (GameOver!)
    {
        string choice = Console.ReadLine();
        string choice2 = Console.ReadLine();
            
//=============Moving from south bank============= 
        Console.WriteLine("What side would you like to move from?");
        
        if (choice2 == "South") ;
        
        Console.WriteLine("What would you like to move?");
            if (choice2 == "Chicken");
            _south.pop(CGame.Item.Chicken);
            _farmerHold.Add(CGame.Item.Chicken);
                //pop chicken from south list
                //add to farmer held inventory
            else if (choice2 == "Fox") ;
            {
                _farmerHold.Add(CGame.Item.Fox);
                //pop Fox from south list
                //add to farmer held inventory
            }
            else if (choice2 == "Grain") ;
            {
                _farmerHold(CGame.Item.Grain);
                //pop Grain from south list
                //add to farmer held inventory
            }
            else ;
            Console.WriteLine("Bad input");
            
            
 //=============Moving fromm north bank=============    
        if (choice2 == "North") ;   

        Console.WriteLine("What would you like to move?");
            if (choice2 == "Chicken");
                //pop chicken from north list
                //add to farmer held inventory
            else if (choice2 == "Fox") ;
                //pop Fox from north list
                //add to farmer held inventory
            else if (choice2 == "Grain") ;
                //pop Grain from north list
                //add to farmer held inventory
            else ;
            Console.WriteLine("Bad input");

    }
    


//=============Win condition=======================
//if north bank continues fox, chicken, grain and farmer = true
//print you win!

//=============Loss condition=====================
//if either bank contains fox + chicken or chicken + grain with no farmer
//print outcome (who eats who) and you lose



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
