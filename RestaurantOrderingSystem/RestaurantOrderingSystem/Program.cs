using RestaurantOrderingSystem;
using System;
using System.Text;

namespace RestaurantSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            RestaurantManager restaurant = new RestaurantManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n СИСТЕМА ЗАМОВЛЕНЬ ");
                Console.WriteLine("1. Показати меню");
                Console.WriteLine("2. Створити замовлення");
                Console.WriteLine("3. Керувати замовленням");
                Console.WriteLine("4. Показати всі замовлення");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        restaurant.ShowMenu();
                        break;
                    case "2":
                        restaurant.CreateOrder();
                        break;
                    case "3":
                        restaurant.ManageOrder();
                        break;
                    case "4":
                        restaurant.ShowAllOrders();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Невідома команда.");
                        break;
                }
            }
        }
    }
}