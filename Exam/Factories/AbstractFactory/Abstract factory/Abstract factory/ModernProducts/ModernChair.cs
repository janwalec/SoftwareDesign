using Abstract_factory.AbstractProducts;

namespace Abstract_factory.ModernProducts;

public class ModernChair : Chair
{
    public void Sit()
    {
        Console.WriteLine("Siting on a modern chair");
    }
}