using CompositeDesignPattern.Interface;

namespace CompositeDesignPattern.Infra
{
    public class Composite : ICustomComponent
    {
        public string Name { get; set; }
        private List<ICustomComponent> Components = new();

        public Composite(string name)
        {
            Name = name;
        }

        public void AddComponent(ICustomComponent component)
        {
            Components.Add(component);
        }

        public decimal CalculatePrice()
        {
            decimal totalPrice = 0;
            foreach (ICustomComponent component in Components)
            {
                totalPrice += component.CalculatePrice();
            }
            return totalPrice;
        }
    }
}