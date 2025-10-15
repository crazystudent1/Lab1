using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        // Метод для демонстрації роботи системи
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            // Створення об'єкта лікарні
            Hospital hospital = new Hospital();

            // 1. Додавання лікарів (мінімум 2-3)
            Console.WriteLine("--- ДОДАВАННЯ ЛІКАРІВ ---");
            Doctor doc1 = new Doctor(1, "Ольга Іваненко", "Терапевт");
            Doctor doc2 = new Doctor(2, "Петро Коваленко", "Хірург");
            Doctor doc3 = new Doctor(3, "Ірина Мельник", "Кардіолог");

            hospital.AddDoctor(doc1);
            hospital.AddDoctor(doc2);
            hospital.AddDoctor(doc3);
            Console.WriteLine();

            // 2. Реєстрація пацієнтів (мінімум 3-4)
            Console.WriteLine("--- РЕЄСТРАЦІЯ ПАЦІЄНТІВ ---");
            Patient pat1 = new Patient(1, "Тарас Шевченко", 35);
            Patient pat2 = new Patient(2, "Леся Українка", 28);
            Patient pat3 = new Patient(3, "Іван Франко", 50);
            Patient pat4 = new Patient(4, "Марія Корицька", 42);

            hospital.RegisterPatient(pat1);
            hospital.RegisterPatient(pat2);
            hospital.RegisterPatient(pat3);
            hospital.RegisterPatient(pat4);
            Console.WriteLine();

            // 3. Створення палат (мінімум 2-3)
            Console.WriteLine("--- СТВОРЕННЯ ПАЛАТ ---");
            HospitalRoom room101 = new HospitalRoom(101, 2); // Місткість 2
            HospitalRoom room102 = new HospitalRoom(102, 3); // Місткість 3
            HospitalRoom room103 = new HospitalRoom(103, 1); // Місткість 1

            hospital.CreateRoom(room101);
            hospital.CreateRoom(room102);
            hospital.CreateRoom(room103);
            Console.WriteLine();

            // 4. Госпіталізація пацієнтів у палати
            Console.WriteLine("--- ГОСПІТАЛІЗАЦІЯ ---");
            hospital.HospitalizePatient(pat1.Id, room101.RoomNumber); // Тарас у 101
            hospital.HospitalizePatient(pat2.Id, room101.RoomNumber); // Леся у 101
            hospital.HospitalizePatient(pat3.Id, room101.RoomNumber); // Іван - 101 переповнена (перевірка)
            hospital.HospitalizePatient(pat4.Id, room102.RoomNumber); // Марія у 102
            hospital.HospitalizePatient(99, room101.RoomNumber); // Пацієнт не знайдений (перевірка)
            hospital.HospitalizePatient(pat3.Id, 999); // Палата не знайдена (перевірка)
            hospital.HospitalizePatient(pat3.Id, room102.RoomNumber); // Іван у 102
            Console.WriteLine();

            // 5. Додавання медичних записів (мінімум 2-3)
            Console.WriteLine("--- МЕДИЧНІ ЗАПИСИ ---");
            MedicalRecord rec1 = new MedicalRecord(pat1, doc1, DateTime.Today.AddDays(-5), "Гострий бронхіт, призначено антибіотики.");
            MedicalRecord rec2 = new MedicalRecord(pat1, doc3, DateTime.Today.AddDays(-2), "Консультація кардіолога. ЕКГ в нормі.");
            MedicalRecord rec3 = new MedicalRecord(pat2, doc2, DateTime.Today, "Незначний перелом. Накладено гіпс.");

            hospital.AddMedicalRecord(rec1);
            hospital.AddMedicalRecord(rec2);
            hospital.AddMedicalRecord(rec3);
            Console.WriteLine();

            // 6. Перегляд історії конкретного пацієнта
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА (ID 1 - Тарас Шевченко) ---");
            var history = hospital.GetPatientHistory(pat1.Id);
            if (history.Any())
            {
                foreach (var record in history)
                {
                    Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                    Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                    Console.WriteLine($"  Опис: {record.Description}\n");
                }
            }
            else
            {
                Console.WriteLine("  Історія прийомів не знайдена.");
            }

            // 7. Виклик та вивід статистики лікарні
            Console.WriteLine("--- ЗАГАЛЬНА СТАТИСТИКА ---");
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}