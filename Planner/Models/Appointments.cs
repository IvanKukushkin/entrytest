using System;
using System.ComponentModel.DataAnnotations;

namespace Planner.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AppointmentDate { get; set; }
        public string Description { get; set; }
    }
}
