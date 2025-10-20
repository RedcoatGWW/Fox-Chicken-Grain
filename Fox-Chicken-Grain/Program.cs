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
        
    


//=============Moving from south bank=============
    bool GameOver = true;
    while (GameOver)
    {
        String Choice = Console.ReadLine();
        Console.WriteLine("What would you like to move?");
        
    }
//=============Moving fromm north bank=============

//=============Win condition=======================

//=============Loss condition=====================




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
