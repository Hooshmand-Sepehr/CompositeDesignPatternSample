using CompositeDesignPattern.Interface;

namespace CompositeDesignPattern.Infra
{
    public class Leaf : ICustomComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Leaf(string name, int price)
        {
            Price = price;
            Name = name;
        }

        public void AddComponent(ICustomComponent component)
        {
            throw new NotImplementedException();
        }

        public decimal CalculatePrice()
        {
            return Price;
        }
    }
}