using Abstract_factory.AbstractProducts;

namespace Abstract_factory.RusticProducts;

public class RusticTable : Table
{
    public void placeItem()
    {
        Console.WriteLine("Placing item on a rustic table");
    }
}