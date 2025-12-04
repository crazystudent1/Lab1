using RestaurantOrderingSystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantSystem
{
    public class RestaurantManager
    {
        private List<MenuItem> _menu;
        private List<Order> _orders;

        public RestaurantManager()
        {
            _menu = new List<MenuItem>();
            _orders = new List<Order>();
            SeedMenu();
        }

        private void SeedMenu()
        {
            _menu.Add(new Dish(1, "Борщ", 120, "Перші страви", 350));
            _menu.Add(new Dish(2, "Стейк Рібай", 450, "М'ясо", 300));
            _menu.Add(new Dish(3, "Цезар", 180, "Салати", 250));
            _menu.Add(new Drink(4, "Кола", 40, 0.5, false));
            _menu.Add(new Drink(5, "Вино червоне", 150, 0.2, true));
            _menu.Add(new Drink(6, "Кава", 50, 0.2, false));
        }

        public void ShowMenu()
        {
            Console.WriteLine("\n МЕНЮ РЕСТОРАНУ ");
            foreach (var item in _menu)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void CreateOrder()
        {
            Console.Write("Введіть номер столика: ");
            if (int.TryParse(Console.ReadLine(), out int tableNum))
            {
                Order newOrder = new Order(tableNum);
                _orders.Add(newOrder);
                Console.WriteLine($"Замовлення #{newOrder.OrderId} створено.");
            }
            else
            {
                Console.WriteLine("Некоректний номер.");
            }
        }

        public void ManageOrder()
        {
            Console.Write("Введіть ID замовлення: ");
            if (!int.TryParse(Console.ReadLine(), out int orderId)) return;

            Order order = _orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                Console.WriteLine("Замовлення не знайдено.");
                return;
            }

            bool editing = true;
            while (editing)
            {
                order.PrintOrderDetails();
                Console.WriteLine("\nДії: 1. Додати страву 2. Змінити статус 3. Вихід в головне меню");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowMenu();
                        Console.Write("Введіть ID страви для додавання: ");
                        if (int.TryParse(Console.ReadLine(), out int itemId))
                        {
                            var item = _menu.FirstOrDefault(m => m.Id == itemId);
                            if (item != null) order.AddItem(item);
                            else Console.WriteLine("Страва не знайдена.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Статуси: 0-New, 1-InProgress, 2-Ready, 3-Paid");
                        Console.Write("Введіть код статусу: ");
                        if (int.TryParse(Console.ReadLine(), out int statusId) && Enum.IsDefined(typeof(OrderStatus), statusId))
                        {
                            order.Status = (OrderStatus)statusId;
                            Console.WriteLine("Статус змінено.");
                        }
                        else Console.WriteLine("Некоректний статус.");
                        break;
                    case "3":
                        editing = false;
                        break;
                }
            }
        }

        public void ShowAllOrders()
        {
            Console.WriteLine("\n АКТИВНІ ЗАМОВЛЕННЯ ");
            foreach (var order in _orders)
            {
                Console.WriteLine($"ID: {order.OrderId} | Стіл: {order.TableNumber} | Статус: {order.Status} | Сума: {order.CalculateTotal()} грн");
            }
        }
    }
}