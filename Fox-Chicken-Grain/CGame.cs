namespace Fox_Chicken_Grain;

public class CGame
{
    //Setting up enums for the items and side of banks
    public enum Item
    {
        Fox,
        Chicken,
        Grain    
    }
    public enum RiverBank
    {
        North,
        South
    } 
    
    //unsure why i have to link directly when they are running in the same solution.
    //Added private data so the values remain static
    private Element.LinkedList _northItems;
    private Element.LinkedList _southItems;
    //setting the starter location of the farmer
    private RiverBank _farmerLocation;

    public CGame()
    {
        //Constructors for the new linked lists for the bank sides to store items
        _northItems = new Element.LinkedList();
        _southItems = new Element.LinkedList();
        _farmerLocation = RiverBank.South;
        
        //Setting the starting location of the items
        _southItems.Add(Item.Fox);
        _southItems.Add(Item.Chicken);
        _southItems.Add(Item.Grain);
    }
    

    
    
    
    
}
//Give your Game class private data as follows – two LinkedLists called _northItems and _southIems, and an
// RiverBank called _farmerLocation.
// Add a constructor to the Game class, and in it set the framer’s initial location to south. Add a fox, a chicken and
// a grain to _southItems.
// Add a public void DisplayBanks() method which displays the items on the river banks and the location of the
// farmer.
// Add a public void DisplayInstructions() method which displays the game’s instructions in the console.