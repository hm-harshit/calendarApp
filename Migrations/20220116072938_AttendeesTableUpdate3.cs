using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalendarApp.Migrations
{
    public partial class AttendeesTableUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Attendees_AttendeesId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_AttendeesId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "AttendeesId",
                table: "Appointment");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Attendees",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_AppointmentId",
                table: "Attendees",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Appointment_AppointmentId",
                table: "Attendees",
                column: "AppointmentId",
                principalTable: "Appointment",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Appointment_AppointmentId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_AppointmentId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Attendees");

            migrationBuilder.AddColumn<int>(
                name: "AttendeesId",
                table: "Appointment",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_AttendeesId",
                table: "Appointment",
                column: "AttendeesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Attendees_AttendeesId",
                table: "Appointment",
                column: "AttendeesId",
                principalTable: "Attendees",
                principalColumn: "Id");
        }
    }
}
