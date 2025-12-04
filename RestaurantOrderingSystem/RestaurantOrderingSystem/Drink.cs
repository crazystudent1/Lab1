using RestaurantOrderingSystem;

namespace RestaurantSystem
{
    public class Drink : MenuItem
    {
        public double VolumeLiters { get; set; }
        public bool IsAlcoholic { get; set; }

        public Drink(int id, string name, decimal price, double volume, bool isAlcoholic)
            : base(id, name, price)
        {
            VolumeLiters = volume;
            IsAlcoholic = isAlcoholic;
        }

        public override string GetDetails()
        {
            string type = IsAlcoholic ? "Алк." : "Безалк.";
            return $"Об'єм: {VolumeLiters}л, {type}";
        }
    }
}