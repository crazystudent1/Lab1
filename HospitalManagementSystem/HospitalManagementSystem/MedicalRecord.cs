using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalManagementSystem
{
    public class MedicalRecord
    {
        // Властивості
        public Patient Patient { get; set; } // Пацієнт
        public Doctor Doctor { get; set; } // Лікар
        public DateTime Date { get; set; } // Дата прийому
        public string Description { get; set; } // Опис діагнозу/призначення

        // Конструктор
        public MedicalRecord(Patient patient, Doctor doctor, DateTime date, string description)
        {
            Patient = patient;
            Doctor = doctor;
            Date = date;
            Description = description;
        }
    }
}