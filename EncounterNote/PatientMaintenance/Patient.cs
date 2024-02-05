using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMaintenance
{
    public class Patient
    {
        public Patient() { }
        public string NoteID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Problems { get; set; }
        public string Notes { get; set; }

    }
}
