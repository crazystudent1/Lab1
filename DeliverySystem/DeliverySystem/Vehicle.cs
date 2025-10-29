namespace DeliverySystem
{
    public class Vehicle
    {
        // Поля з модифікатором protected для доступу в похідних класах
        protected string brand;
        protected int year;
        protected double mileage;
        protected double maxSpeed;

        // Оновлений конструктор для можливості передачі maxSpeed від Van через Car
        public Vehicle(string brand, int year, double mileage, double maxSpeed)
        {
            this.brand = brand;
            this.year = year;
            this.mileage = mileage;
            this.maxSpeed = maxSpeed;
        }

        // Віртуальний метод для отримання інформації
        public virtual string GetInfo()
        {
            return $"{brand} ({year}), Mileage: {mileage} km";
        }

        // Віртуальний метод для отримання максимальної швидкості
        public virtual double GetMaxSpeed()
        {
            return maxSpeed;
        }

        // Віртуальний метод для руху
        public virtual void Move(double distance)
        {
            mileage += distance;
            Console.WriteLine($"{brand} drove {distance} km.");
        }
    }
}