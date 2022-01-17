using System.ComponentModel.DataAnnotations;

namespace CalendarApp.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0: MM/dd/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Time { get; set; }
        public string? Organizer { get; set; }
        public string? Subject { get; set; }
        public virtual ICollection<Attendees> Attendees { get; set; }
    }
}