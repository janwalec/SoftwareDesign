using Abstract_factory.AbstractProducts;

namespace Abstract_factory.ModernProducts;

public class ModernTable : Table
{
    public void placeItem()
    {
        Console.WriteLine("Placing item on a modern table");
    }
}