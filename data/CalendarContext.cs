#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CalendarApp.Models;

    public class CalendarAppContext : DbContext
    {
        public CalendarAppContext (DbContextOptions<CalendarAppContext> options)
            : base(options)
        {
        }

        public DbSet<CalendarApp.Models.Appointment> Appointment { get; set; }
        public DbSet<CalendarApp.Models.Attendees> Attendees { get; set; }
    }
