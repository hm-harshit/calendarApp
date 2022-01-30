using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;
using CalendarApp.Models;


namespace CalendarApp.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly CalendarAppContext _context;

        public AppointmentService(CalendarAppContext context)
        {
            _context = context;
        }
        public async Task<List<Appointment>> getAppointmentsByMonth(int month)  
        {
            var Appointments = await _context.Appointment.Include("Attendees").Where(s => s.Time.Month == month).ToListAsync();
            return Appointments;
        }

    }
}