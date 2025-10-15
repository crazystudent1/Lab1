using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalManagementSystem
{

    public class Doctor
    {
        // Властивості
        public int Id { get; set; } // Унікальний ідентифікатор лікаря
        public string Name { get; set; } // Ім'я лікаря
        public string Specialization { get; set; } // Спеціалізація (наприклад, терапевт, хірург)

        // Конструктор
        public Doctor(int id, string name, string specialization)
        {
            Id = id;
            Name = name;
            Specialization = specialization;
        }
    }
}