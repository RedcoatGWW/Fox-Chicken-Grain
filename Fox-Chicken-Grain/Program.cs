namespace Fox_Chicken_Grain;

class Program
{
    
    
    static void Main(string[] args)
    {
        //testing calling the items
        // CGame.Item item1 = CGame.Item.Fox;
        // CGame.Item item2 = CGame.Item.Chicken; 
        // CGame.Item item3 = CGame.Item.Grain;
        //
        // Console.Write(item1);
        // Console.Write(item2);
        // Console.Write(item3);
        
        CGame Play = new CGame();
        Play.DisplayBanks();
        
        Console.ReadLine();

    }
}