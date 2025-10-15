// HospitalRoom.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalManagementSystem
{
    public class HospitalRoom
    {
        // Властивості
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; }

        // Конструктор
        public HospitalRoom(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            Patients = new List<Patient>();
        }

        // Метод: додає пацієнта, якщо є вільне місце
        public void AddPatient(Patient patient)
        {
            if (Patients.Count < Capacity)
            {
                Patients.Add(patient);
                // Вивід, який вимагають тести
                Console.WriteLine($"Пацієнт {patient.Name} доданий у палату №{RoomNumber}");
            }
            else
            {
                // Вивід, який вимагають тести (з ключовим словом "переповнена")
                Console.WriteLine($"Палата №{RoomNumber} переповнена! Неможливо додати пацієнта.");
            }
        }
    }
}