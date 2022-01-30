using Xunit;
using CalendarApp.Controllers;
using CalendarApp.Models;
using CalendarApp.Services;
using Moq;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;  
using Microsoft.AspNetCore.Mvc;

namespace CalendarAppUnitTests.Controllers
{
    public class CalendarAppTests
    {
       
        public Mock<IAppointmentService> mock = new Mock<IAppointmentService>();  

        [Fact]
        public async Task Can_Check_For_View_Result_Data()
        {
           // Arrange
            var data = new List<Appointment> {
               new Appointment
                    {
                        Id = 1,
                        Name = "The Expert Conference",
                        Time = DateTime.Parse("2020-01-12 09:10:00"),
                        Organizer = "Romantic Comedy",
                        Subject = "The Expert Conference",
                        Attendees = new List<Attendees>{
                            new Attendees{
                                Id = 1,
                                name = "John Smith",
                                AppointmentID = 1
                            }
                        }
                    },
            };
            mock.Setup(p => p.getAppointmentsByMonth(1)).ReturnsAsync(data).Verifiable();

            // Act
            var emp = new CalendarController(mock.Object);  
            var result = await emp.month(1);


             // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Appointment>>(
                viewResult.ViewData.Model);

            Assert.Equal(1,model.Single(s => s.Id == 1).Id);
            Assert.Equal("The Expert Conference",model.Single(s => s.Id == 1).Name);
            Assert.Equal(DateTime.Parse("2020-1-12 09:10:00"),model.Single(s => s.Id == 1).Time);
            Assert.Equal("Romantic Comedy",model.Single(s => s.Id == 1).Organizer);
            Assert.Equal("The Expert Conference",model.Single(s => s.Id == 1).Subject);
            Assert.Equal(1,model.Single(s => s.Id == 1).Attendees.Single(s => s.Id == 1).Id);
            Assert.Equal("John Smith",model.Single(s => s.Id == 1).Attendees.Single(s => s.Id == 1).name);
            Assert.Equal(1,model.Single(s => s.Id == 1).Attendees.Single(s => s.Id == 1).AppointmentID);
            Assert.Equal(data, model);
        }
    }
}