using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CalendarApp.Models;


namespace CalendarApp.Services
{
    public interface IAppointmentService  
    {  
        Task<List<Appointment>> getAppointmentsByMonth(int month);  
    } 

}