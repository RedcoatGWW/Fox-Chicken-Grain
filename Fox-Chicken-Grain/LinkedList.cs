namespace Fox_Chicken_Grain;

public class Element
{
    
    private CGame.Item _data;
    private Element? _next;
    
    public Element(CGame.Item data)
    {
        _data = data;
        _next = null;
    }

    public CGame.Item Data
    {
        get { return _data; }
        set { _data = value; }
    }

    public Element? Next
    {
        get { return _next; }
        set { _next = value; }
    }

    public class LinkedList
    {
        private Element? _head;
        
        public LinkedList()
        {
            _head = null;
        }

        public void Add(CGame.Item item)
        {   
            //Adds a new item to the head of the stack
            Element newElement = new Element(item);
            newElement.Next = _head;
            _head = newElement;
        }

        public void PopFront()
        {
            if (_head != null)
            {
                _head = _head.Next;
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }

        public void PrintList()
        {
            Element? current = _head;

            if (current == null)
            {
                Console.WriteLine("Nothing");
                return;
            }

            while (current != null)
            {
                Console.Write(current.Data);
                if (current.Next != null)
                    Console.Write(" - ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public bool HasValue(CGame.Item value)
        {
            Element? current = _head;
            while (current != null)
            {
                if (current.Data == value)
                    return true;
                current = current.Next;
            }
            return false;
        }

        public List<CGame.Item> ToList()
        {
            List<CGame.Item> items = new List<CGame.Item>();
            Element? current = _head;
            while (current != null)
            {
                items.Add(current.Data);
                current = current.Next;
            }
            return items;
        }

        public int Size()
        {
            int count = 0;
            Element? current = _head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }
    }

    
    

    
}