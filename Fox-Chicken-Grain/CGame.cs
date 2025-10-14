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

    //Method to display the lists for the main game
    public void DisplayBanks()
    {
        Console.WriteLine("North Bank");
        _northItems.PrintList();

        Console.WriteLine();
        Console.WriteLine("South Bank");
        _southItems.PrintList();

        Console.WriteLine();
        Console.WriteLine($"Farmer is on the {_farmerLocation} bank.");


    }

    //Displays the introduction and instructions for the game
    public void DisplayInstructions()
    {
        Console.WriteLine("Welcome to Fox-Chicken-Grain!");
        Console.WriteLine(
            "A particularly stupid farmer must get his fox, chicken and grain safely across a river, from the south river\nbank to the north bank. The farmer makes trips across the river in a little boat, but can only take at most\none item with him on each trip. If he leaves the fox and the chicken alone together, the fox will eat the\nchicken! If he leaves the chicken alone with the grain, the chicken will eat the grain. The player must\nhelp the farmer by deciding what he should take with him (or nothing) on each trip. Once all three items\nare on the north bank, the game is won. If anything gets eaten, the game is lost.");
    }

    
        //If northItems contains 3 items + farmer
        // return 'You have won'
        public bool isWon()
        {
            int count = 0;
            Element.LinkedList? current = _northItems;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count == 3;
        }

}

    // public bool isLost()

// Add a public bool isWon() method. The method takes no parameters, and returns true if all 3 items are on the
    // north bank of the river. A message should also be displayed.
    //     Add a public bool isLost() method. This method should take a LinkedList reference called withoutFarmer. If an
    // item and its food are on the bank (assuming the farmer is not), the method should return true. Also, output a
    // message saying who ate what(!), and that the game is lost.
