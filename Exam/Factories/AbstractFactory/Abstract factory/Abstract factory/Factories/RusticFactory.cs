using Abstract_factory.AbstractProducts;
using Abstract_factory.RusticProducts;

namespace Abstract_factory.Factories;

public class RusticFactory : IFactory
{
    public Chair CreateChair()
    {
        return new RusticChair();
    }

    public Sofa CreateSofa()
    {
        return new RusticSofa();
    }

    public Table CreateTable()
    {
        return new RusticTable();
    }
}