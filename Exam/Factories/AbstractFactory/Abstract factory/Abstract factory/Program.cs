


using Abstract_factory.AbstractProducts;
using Abstract_factory.Factories;

IFactory modernFactory = new ModernFactory();
IFactory rusticFactory = new RusticFactory();

List<Chair> chairs = new List<Chair>();
List<Table> tables = new List<Table>();
List<Sofa> sofas = new List<Sofa>();

chairs.Add(modernFactory.CreateChair());
chairs.Add(rusticFactory.CreateChair());
tables.Add(modernFactory.CreateTable());
tables.Add(rusticFactory.CreateTable());
sofas.Add(modernFactory.CreateSofa());
sofas.Add(rusticFactory.CreateSofa());


foreach (Chair chair in chairs) {
    chair.Sit();
}

foreach (Table table in tables)
{
    table.placeItem();
}

foreach (Sofa sofa in sofas)
{
    sofa.LieDown();
}