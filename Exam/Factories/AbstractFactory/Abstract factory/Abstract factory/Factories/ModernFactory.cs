using Abstract_factory.AbstractProducts;
using Abstract_factory.ModernProducts;

namespace Abstract_factory.Factories;

public class ModernFactory : IFactory
{
    public Chair CreateChair()
    {
        return new ModernChair();
    }

    public Sofa CreateSofa()
    {
        return new ModernSofa();
    }

    public Table CreateTable()
    {
        return new ModernTable();
    }
}