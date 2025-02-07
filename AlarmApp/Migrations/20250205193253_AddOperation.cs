using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlarmApp.Migrations
{
    /// <inheritdoc />
    public partial class AddOperation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AlarmBeforeHours",
                table: "Alarms",
                newName: "Tags");

            migrationBuilder.AddColumn<string>(
                name: "DaysBeforeAlarm",
                table: "Alarms",
                type: "TEXT",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysBeforeAlarm",
                table: "Alarms");

            migrationBuilder.RenameColumn(
                name: "Tags",
                table: "Alarms",
                newName: "AlarmBeforeHours");
        }
    }
}
