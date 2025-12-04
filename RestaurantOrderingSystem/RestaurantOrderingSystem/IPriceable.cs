namespace RestaurantOrderingSystem
{
    public interface IPriceable
    {
        string Name { get; }
        decimal Price { get; }
        string GetDescription();
    }
}