﻿namespace DeliverySystem
{
    public class Car : Vehicle
    {
        protected int doors;
        protected double fuelLevel;

        // Зберігаємо параметр за замовчуванням 180.0
        public Car(string brand, int year, double mileage, int doors, double maxSpeed = 180.0)
            : base(brand, year, mileage, maxSpeed)
        {
            this.doors = doors;
            this.fuelLevel = 50.0;
        }

       
        public override string GetInfo()
        {
            // Форматуємо fuelLevel як ціле число (0 знаків після коми)
            return $"Car: {brand} ({year}), Doors: {doors}, Fuel: {fuelLevel.ToString("F0")}L";
        }

        public override void Move(double distance)
        {
            base.Move(distance);

            fuelLevel -= distance * 0.1;
            if (fuelLevel < 0)
            {
                fuelLevel = 0;
            }
        }

        public void Refuel(double liters)
        {
            fuelLevel += liters;
            if (fuelLevel > 50.0)
            {
                fuelLevel = 50.0;
            }
        }
    }
}