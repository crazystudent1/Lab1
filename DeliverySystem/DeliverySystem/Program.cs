namespace DeliverySystem
{
    public class Program
    {
        public static void Main()
        {
            // Створення екземплярів різних транспортних засобів
            Vehicle scooter = new Scooter("Xiaomi", 2023, 1200, 30);
            // Для Car використовується maxSpeed за замовчуванням (180.0)
            Vehicle car = new Car("Toyota", 2021, 34000, 4);
            // Для Van передається maxSpeed = 140.0 через конструктор Car
            Vehicle van = new Van("Ford", 2020, 56000, 5, 1000);

            // --- Демонстрація Scooter ---
            Console.WriteLine(scooter.GetInfo());
            Console.WriteLine($"Max speed: {scooter.GetMaxSpeed()} km/h");
            scooter.Move(20);
            // Явне приведення типів для доступу до унікального методу Charge()
            ((Scooter)scooter).Charge();

            Console.WriteLine("---");

            // --- Демонстрація Car ---
            Console.WriteLine(car.GetInfo());
            Console.WriteLine($"Max speed: {car.GetMaxSpeed()} km/h");
            car.Move(50);
            // Явне приведення типів не потрібне для GetInfo()/Move() через поліморфізм

            Console.WriteLine("---");

            // --- Демонстрація Van ---
            Console.WriteLine(van.GetInfo());
            Console.WriteLine($"Max speed: {van.GetMaxSpeed()} km/h");
            // Явне приведення типів для доступу до унікальних методів LoadCargo() / UnloadCargo()
            ((Van)van).LoadCargo(800);
            Console.WriteLine(van.GetInfo());
            ((Van)van).LoadCargo(300);
            ((Van)van).UnloadCargo();
        }
    }
}
