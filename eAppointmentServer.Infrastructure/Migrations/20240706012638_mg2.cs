using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAppointmentServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullAdress",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "FullAddress",
                table: "Patients",
                type: "varchar(400)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullAddress",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "FullAdress",
                table: "Patients",
                type: "varchar(500)",
                nullable: false,
                defaultValue: "");
        }
    }
}
