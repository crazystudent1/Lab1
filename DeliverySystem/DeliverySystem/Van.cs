﻿namespace DeliverySystem
{
    public class Van : Car
    {
        private double loadCapacity;
        private double currentLoad;

        public Van(string brand, int year, double mileage, int doors, double loadCapacity)
            // Передаємо 140.0 до конструктора Car
            : base(brand, year, mileage, doors, 140.0)
        {
            this.loadCapacity = loadCapacity;
            this.currentLoad = 0.0;
        }

       
        public override string GetInfo()
        {
            // Форматуємо fuelLevel як ціле число
            return $"Van: {brand} ({year}), Doors: {doors}, Load: {currentLoad}/{loadCapacity}kg, Fuel: {fuelLevel.ToString("F0")}L";
        }

        public void LoadCargo(double weight)
        {
            if (currentLoad + weight <= loadCapacity)
            {
                currentLoad += weight;
                Console.WriteLine($"{weight} kg loaded into the van.");
            }
            else
            {
                Console.WriteLine("Too heavy! Cannot load more cargo.");
            }
        }

        public void UnloadCargo()
        {
            currentLoad = 0.0;
            Console.WriteLine("Van unloaded.");
        }
    }
}