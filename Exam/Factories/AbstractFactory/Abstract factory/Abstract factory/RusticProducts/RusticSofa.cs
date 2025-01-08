using Abstract_factory.AbstractProducts;

namespace Abstract_factory.RusticProducts;

public class RusticSofa : Sofa
{
    public void LieDown()
    {
        Console.WriteLine("Laying on a rustic sofa");
    }
}