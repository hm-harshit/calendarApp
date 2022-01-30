using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CalendarApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CalendarAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CalendarAppContext>>()))
            {
                // Look for any Appointments.
                if (context.Appointment.Any())
                {
                    return;   // DB has been seeded
                }

                context.Appointment.AddRange(
                    new Appointment
                    {
                        Name = "The Expert Conference",
                        Time = DateTime.Parse("2020-1-12 09:10:00"),
                        Organizer = "Romantic Comedy",
                        Subject = "The Expert Conference"
                    },

                    new Appointment
                    {
                        Name = "The Millennial Conference",
                        Time = DateTime.Parse("2020-1-12 10:10:00"),
                        Organizer = "Romantic Comedy",
                        Subject = "The Millennial Conference"
                    },

                    new Appointment
                    {
                        Name = "Team Meeting",
                        Time = DateTime.Parse("2020-2-02 10:10:00"),
                        Organizer = "Organizer Agency",
                        Subject = "The Team Meeting"
                    },
                    new Appointment
                    {
                        Name = "Lunch with Joe",
                        Time = DateTime.Parse("2020-2-12 09:10:00"),
                        Organizer = "Max Mustermann",
                        Subject = "Lunch with Joe"
                    },

                    new Appointment
                    {
                        Name = "Project Meeting",
                        Time = DateTime.Parse("2020-2-13 10:10:00"),
                        Organizer = "Max Mustermann",
                        Subject = "The Project Meeting"
                    },
                    new Appointment
                    {
                        Name = "The Millennial Conference",
                        Time = DateTime.Parse("2020-3-10 10:10:00"),
                        Organizer = "Romantic Comedy",
                        Subject = "The Millennial Conference"
                    },


                     new Appointment
                     {
                         Name = "Project Meeting",
                         Time = DateTime.Parse("2020-4-13 10:10:00"),
                         Organizer = "Max Mustermann",
                         Subject = "The Project Meeting"
                     },

                    new Appointment
                    {
                        Name = "The Millennial Conference",
                        Time = DateTime.Parse("2020-5-10 10:10:00"),
                        Organizer = "Romantic Comedy",
                        Subject = "The Millennial Conference"
                    },
                    new Appointment
                    {
                        Name = "Developer Conference",
                        Time = DateTime.Parse("2020-6-10 10:10:00"),
                        Organizer = "The Pack Experty",
                        Subject = "The Developer Conference"
                    },
                     new Appointment
                     {
                         Name = "Developer Conference - 2",
                         Time = DateTime.Parse("2020-6-12 10:10:00"),
                         Organizer = "The Pack Experty",
                         Subject = "The Developer Conference"
                     }
                    ,
                     new Appointment
                     {
                         Name = "Developer Conference - 1",
                         Time = DateTime.Parse("2020-7-12 10:10:00"),
                         Organizer = "Professional Tidy",
                         Subject = "The Developer Conference"
                     }

                    ,
                     new Appointment
                     {
                         Name = "The Millennial Conference",
                         Time = DateTime.Parse("2020-8-12 10:10:00"),
                         Organizer = "The Pack Experty",
                         Subject = "The Millennial Conference"
                     }
                    ,
                     new Appointment
                     {
                         Name = "Business Conference",
                         Time = DateTime.Parse("2020-8-12 10:10:00"),
                         Organizer = "The Pack Experty",
                         Subject = "Business Conference"
                     }

                    ,
                     new Appointment
                     {
                         Name = "Business Conference",
                         Time = DateTime.Parse("2020-9-12 10:10:00"),
                         Organizer = "The Pack Experty",
                         Subject = "The Developer Conference"
                     }
                    ,
                     new Appointment
                     {
                         Name = "Business Conference",
                         Time = DateTime.Parse("2020-10-12 10:10:00"),
                         Organizer = "The Pack Experty",
                         Subject = "The Business Conference"
                     }
                    ,
                     new Appointment
                     {
                         Name = "Business Conference",
                         Time = DateTime.Parse("2020-11-12 10:10:00"),
                         Organizer = "The Pack Experty",
                         Subject = "The Business Conference"
                     }
                    ,
                     new Appointment
                     {
                         Name = "Business Conference",
                         Time = DateTime.Parse("2020-12-12 10:10:00"),
                         Organizer = "The Pack Experty",
                         Subject = "The Business Conference"
                     }

                );
                context.SaveChanges();
                context.Attendees.AddRange(
                     new Attendees{
                          name = "Francesco Pio Hildingr",
                          AppointmentID = context.Appointment.Single(s => s.Id == 1).Id
                     },
                      new Attendees{
                          name = "John Smith",
                          AppointmentID = context.Appointment.Single(s => s.Id == 2).Id
                     },
                      new Attendees{
                          name = "Robert Turner",
                          AppointmentID = context.Appointment.Single(s => s.Id == 3).Id
                     },
                      new Attendees{
                          name = "Erika Gabler",
                          AppointmentID = context.Appointment.Single(s => s.Id == 4).Id
                     },
                      new Attendees{
                          name = "Petya Annelise",
                          AppointmentID = context.Appointment.Single(s => s.Id == 4).Id
                     },
                      new Attendees{
                          name = "Sjoerd Pratima",
                          AppointmentID = context.Appointment.Single(s => s.Id == 5).Id
                     },
                      new Attendees{
                          name = "Alysia Óengus",
                          AppointmentID = context.Appointment.Single(s => s.Id == 6).Id
                     },
                      new Attendees{
                          name = "Isbrand Philandros",
                          AppointmentID = context.Appointment.Single(s => s.Id == 7).Id
                     },
                      new Attendees{
                          name = "Sebastián Poornima",
                          AppointmentID = context.Appointment.Single(s => s.Id == 8).Id
                     },
                      new Attendees{
                          name = "Sankar Barney",
                          AppointmentID = context.Appointment.Single(s => s.Id == 9).Id
                     },
                      new Attendees{
                          name = "Ekua Dipti",
                          AppointmentID = context.Appointment.Single(s => s.Id == 10).Id
                     },
                      new Attendees{
                          name = "Khasan Murielle",
                          AppointmentID = context.Appointment.Single(s => s.Id == 11).Id
                     },
                      new Attendees{
                          name = "Birutė Vilma",
                          AppointmentID = context.Appointment.Single(s => s.Id == 12).Id
                     },
                      new Attendees{
                          name = "Malaika Željko",
                          AppointmentID = context.Appointment.Single(s => s.Id == 9).Id
                     },
                      new Attendees{
                          name = "John Smith",
                          AppointmentID = context.Appointment.Single(s => s.Id == 12).Id
                     }

                );
                context.SaveChanges();
            }
        }
    }
}