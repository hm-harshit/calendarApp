using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;
using CalendarApp.Models;


namespace CalendarApp.Controllers
{
    public class CalendarController : Controller
    {
        private readonly CalendarAppContext _context;

        public CalendarController(CalendarAppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> month(int id = 0)
        {

            if(id == 0 || id > 12) {
               return Redirect("/Calendar/Month/1");
            }
             var Appointments = from m in _context.Appointment.Include("Attendees")
                select m;
           
            Appointments = Appointments.Where(s => s.Time.Month == id);

            return View(await Appointments.ToListAsync());
        }

    }
}