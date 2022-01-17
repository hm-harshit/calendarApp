using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalendarApp.Migrations
{
    public partial class AttendeesTableUpdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Appointment_AppointmentId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "Appointment_id",
                table: "Attendees");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "Attendees",
                newName: "AppointmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Attendees_AppointmentId",
                table: "Attendees",
                newName: "IX_Attendees_AppointmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Appointment_AppointmentID",
                table: "Attendees",
                column: "AppointmentID",
                principalTable: "Appointment",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Appointment_AppointmentID",
                table: "Attendees");

            migrationBuilder.RenameColumn(
                name: "AppointmentID",
                table: "Attendees",
                newName: "AppointmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendees_AppointmentID",
                table: "Attendees",
                newName: "IX_Attendees_AppointmentId");

            migrationBuilder.AddColumn<int>(
                name: "Appointment_id",
                table: "Attendees",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Appointment_AppointmentId",
                table: "Attendees",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id");
        }
    }
}
