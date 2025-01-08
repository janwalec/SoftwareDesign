using Abstract_factory.AbstractProducts;

namespace Abstract_factory.RusticProducts;

public class RusticChair : Chair
{
    public void Sit()
    {
        Console.WriteLine("Sitting on a rustic chair");
    }
}