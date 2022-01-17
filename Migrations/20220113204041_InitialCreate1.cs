using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalendarApp.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Appointment",
                newName: "Time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Appointment",
                newName: "Date");
        }
    }
}
