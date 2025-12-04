using RestaurantOrderingSystem;

namespace RestaurantSystem
{
    public class Dish : MenuItem
    {
        public string Category { get; set; }
        public int WeightGrams { get; set; }

        public Dish(int id, string name, decimal price, string category, int weight)
            : base(id, name, price)
        {
            Category = category;
            WeightGrams = weight;
        }

        public override string GetDetails()
        {
            return $"Категорія: {Category}, Вага: {WeightGrams}г";
        }
    }
}