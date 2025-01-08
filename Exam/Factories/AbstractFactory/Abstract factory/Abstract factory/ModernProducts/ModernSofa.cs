using Abstract_factory.AbstractProducts;

namespace Abstract_factory.ModernProducts;

public class ModernSofa : Sofa
{
    public void LieDown()
    {
        Console.WriteLine("Laying down on a modern sofa");
    }
}