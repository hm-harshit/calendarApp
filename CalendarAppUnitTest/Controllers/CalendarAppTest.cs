using NUnit.Framework;
using System;
using CalendarApp.Controllers;
using CalendarApp.Models;
using Moq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace CalendarAppUnitTest.Controllers
{
    internal class CalendarAppTest
    {
       
        private CalendarController? _CalendarController;
        private Mock<CalendarAppContext> _dataServiceMock;

        [SetUp]
        public void Setup()
        {
            _dataServiceMock = new Mock<CalendarAppContext>();
            _CalendarController = new CalendarController(_dataServiceMock.Object);
        }

        [Test]
        public async void Can_Check_For_View_Result_Data()
        {
            //Arrange
           
            _dataServiceMock.Setup(service => service.AppointmentList()).Returns(Task.FromResult(new List<Appointment> {

               new Appointment
                    {
                        Id = 1,
                        Name = "The Expert Conference",
                        Time = DateTime.Parse("2020-1-12 09:10:00"),
                        Organizer = "Romantic Comedy",
                        Subject = "The Expert Conference",
                        Attendees = new Attendees
                        {
                            name = "John Smith",
                            AppointmentID = Appointment.Single(s => s.Id == 1).Id
                        }
                    },
                
            }));

            //Act 
            var result = await _CalendarController.month() as ViewViewComponentResult;
            var model = result.CalendarApp.Models as IEnumerable<Appointment>;


            //Assert
            Assert.IsTrue(model.Any(x => x.Id == 1));
            Assert.IsTrue(model.Any(x => x.Name == "The Expert Conference"));
            Assert.IsTrue(model.Any(x => x.Time == DateTime.Parse("2020-1-12 09:10:00")));
            Assert.IsTrue(model.Any(x => x.Organizer == "Romantic Comedy"));
            Assert.IsTrue(model.Any(x => x.Subject == "The Expert Conference"));
      
        }
    }
}
