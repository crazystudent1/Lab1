using RestaurantOrderingSystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantSystem
{
    public class Order
    {
        private static int _globalIdCounter = 1;

        public int OrderId { get; private set; }
        public int TableNumber { get; private set; }
        public OrderStatus Status { get; set; }

        // Агрегація
        private List<MenuItem> _items;

        public Order(int tableNumber)
        {
            OrderId = _globalIdCounter++;
            TableNumber = tableNumber;
            Status = OrderStatus.New;
            _items = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            _items.Add(item);
            Console.WriteLine($"Додано: {item.Name} у замовлення #{OrderId}");
        }

        public void RemoveItem(MenuItem item)
        {
            if (_items.Remove(item))
            {
                Console.WriteLine($"Видалено: {item.Name} із замовлення #{OrderId}");
            }
            else
            {
                Console.WriteLine("Позицію не знайдено.");
            }
        }

        public decimal CalculateTotal()
        {
            return _items.Sum(x => x.Price);
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine($"\n--- Замовлення #{OrderId} (Стіл: {TableNumber}) ---");
            Console.WriteLine($"Статус: {Status}");

            if (_items.Count == 0)
            {
                Console.WriteLine("  Список порожній.");
            }
            else
            {
                foreach (var item in _items)
                {
                    // Перевірка типів (is / as)
                    if (item is Drink)
                    {
                        Drink d = item as Drink;
                        Console.WriteLine($"  [Напій] {d.Name} ({d.VolumeLiters}л) - {d.Price} грн");
                    }
                    else if (item is Dish)
                    {
                        Console.WriteLine($"  [Їжа]   {item.Name} - {item.Price} грн");
                    }
                    else
                    {
                        Console.WriteLine($"  {item.Name} - {item.Price}");
                    }
                }
                Console.WriteLine($"---------------------------");
                Console.WriteLine($"ЗАГАЛОМ: {CalculateTotal()} грн");
            }
        }
    }
}