using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;
using CalendarApp.Models;
using CalendarApp.Services;


namespace CalendarApp.Controllers
{
    public class CalendarController : Controller
    {
         private readonly IAppointmentService _appointmentService;  

        public CalendarController( IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;  
        }
        public async Task<IActionResult> month(int id = 0)
        {
            if(id == 0 || id > 12) {
               return Redirect("/Calendar/Month/1");
            }
             var Appointments = await _appointmentService.getAppointmentsByMonth(id);
            return View(Appointments);
        }

    }
}