namespace Fox_Chicken_Grain;

public class CGame
{
    //Setting up enums for the items and side of banks
    public enum Item
    {
        Fox,
        Chicken,
        Grain,
        Farmer
    }
    public enum RiverBank
    {
        North,
        South
    }

    //unsure why i have to link directly when they are running in the same solution.
    //Added private data so the values remain static
    public Element.LinkedList _north;
    public Element.LinkedList _south;
    public Element.LinkedList _farmerHold;

    //setting the starter location of the farmer
    public RiverBank _farmerLocation;

    public CGame()
    {
        //Constructors for the new linked lists for the bank sides to store items
        _north = new Element.LinkedList();
        _south = new Element.LinkedList();
        _farmerHold = new Element.LinkedList();
        //Item.Farmer = _farmerLocation;
        //_farmerLocation = RiverBank.South;

        //Setting the starting location of the items
        _south.Add(Item.Fox);
        _south.Add(Item.Chicken);
        _south.Add(Item.Grain);
        _south.Add(Item.Farmer);
    }

    //Method to display the lists for the main game
    public void DisplayBanks()
    {
        Console.WriteLine("North Bank");
        _north.PrintList();

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine();
        Console.WriteLine($"South Bank");
        _south.PrintList();

        Console.WriteLine();
        
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
        if (_north.Contains(Item.Fox) && _north.Contains(Item.Chicken) && _north.Contains(Item.Grain) && _north.Contains(Item.Farmer))
        {
            Console.WriteLine("You Win!!");
            return true;
        } else
        {
            return false;
        }
    }

    public bool isLost()
    {
        if (_north.Contains(Item.Chicken) && _north.Contains(Item.Grain) && _south.Contains(Item.Farmer))
        {
            Console.WriteLine("The chicken has eaten the grain! You lose!");
            return true;
        }
        else if (_north.Contains(Item.Fox) && _north.Contains(Item.Chicken) && _south.Contains(Item.Farmer))
        {
            Console.WriteLine("The fox has eaten the chicken! You lose!");
            return true;
        }
        else if (_south.Contains(Item.Chicken) && _south.Contains(Item.Grain) && _north.Contains(Item.Farmer))
        {
            Console.WriteLine("The chicken has eaten the grain! You lose!");
            return true;
        }
        else if (_south.Contains(Item.Fox) && _south.Contains(Item.Chicken) && _north.Contains(Item.Farmer))
        {
            Console.WriteLine("The fox has eaten the chicken! You lose!");
            return true;
        }
        else
        {
            return false;
        }
    }

}

// public bool isLost()

// Add a public bool isWon() method. The method takes no parameters, and returns true if all 3 items are on the
// north bank of the river. A message should also be displayed.
//     Add a public bool isLost() method. This method should take a LinkedList reference called withoutFarmer. If an
// item and its food are on the bank (assuming the farmer is not), the method should return true. Also, output a
// message saying who ate what(!), and that the game is lost.
