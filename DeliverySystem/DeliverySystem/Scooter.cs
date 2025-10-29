﻿namespace DeliverySystem
{
    public class Scooter : Vehicle
    {
        private int batteryCapacity;
        private double batteryLevel;

        public Scooter(string brand, int year, double mileage, int batteryCapacity)
            : base(brand, year, mileage, 45.0)
        {
            this.batteryCapacity = batteryCapacity;
            this.batteryLevel = 100.0;
        }

        
        public override string GetInfo()
        {
            // Форматуємо batteryLevel як ціле число
            return $"Scooter: {brand} ({year}), Battery: {batteryLevel.ToString("F0")}% of {batteryCapacity}Ah";
        }

        public override void Move(double distance)
        {
            base.Move(distance);

            batteryLevel -= distance * 0.5;
            if (batteryLevel < 0)
            {
                batteryLevel = 0;
            }
        }

        public void Charge()
        {
            batteryLevel = 100.0;
            Console.WriteLine($"{brand} has been fully charged.");
        }
    }
}