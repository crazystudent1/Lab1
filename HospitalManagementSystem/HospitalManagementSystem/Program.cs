// Program.cs

using System;
using System.Text;
namespace HospitalManagementSystem
{
    // КЛАС ОБОВ'ЯЗКОВО ПОВИНЕН БУТИ PUBLIC
    public class Program
    {
        public static void Main(string[] args)
        {
            // Встановлення кодування UTF8 для коректного виводу кирилиці
            Console.OutputEncoding = Encoding.UTF8;

            HospitalDemo demo = new HospitalDemo();
            demo.Run();

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}