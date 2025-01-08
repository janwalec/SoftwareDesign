using Abstract_factory.AbstractProducts;

namespace Abstract_factory.Factories;

public interface IFactory
{
    public Chair CreateChair();
    public Sofa CreateSofa();
    public Table CreateTable();
}