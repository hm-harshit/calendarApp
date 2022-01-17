using System.ComponentModel.DataAnnotations;

namespace CalendarApp.Models
{
    public class Attendees
    {
        public int Id { get; set; }
        public int? AppointmentID { get; set; }
        public string? name { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}