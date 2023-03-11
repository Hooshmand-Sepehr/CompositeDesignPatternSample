namespace CompositeDesignPattern.Interface
{
    public interface ICustomComponent
    {
        void AddComponent(ICustomComponent component);

        decimal CalculatePrice();
    }
}