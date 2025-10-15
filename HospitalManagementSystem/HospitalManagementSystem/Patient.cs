using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalManagementSystem
{
    public class Patient
    {
        // Властивості
        public int Id { get; set; } // Унікальний ідентифікатор пацієнта
        public string Name { get; set; } // Ім'я пацієнта
        public int Age { get; set; } // Вік пацієнта

        // Конструктор
        public Patient(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}