
namespace RestaurantOrderingSystem
{
    public abstract class MenuItem : IPriceable
    {
        public int Id { get; private set; }
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }

        protected MenuItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        // Абстрактний метод
        public abstract string GetDetails();

        // Віртуальний метод
        public virtual string GetDescription()
        {
            return $"{Name} - {Price} грн";
        }

        public override string ToString()
        {
            return $"{Id}. {GetDescription()} ({GetDetails()})";
        }
    }
}