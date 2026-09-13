using System;
using System.Collections.Generic;
using System.Text;

namespace ReminderApp.Models
{
    public class Medication
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Notes { get; set; }
        public string Time { get; set; }
    }
}
