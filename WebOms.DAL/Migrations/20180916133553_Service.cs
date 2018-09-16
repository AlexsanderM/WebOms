using Microsoft.EntityFrameworkCore.Migrations;

namespace WebOms.DAL.Migrations
{
    public partial class Service : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Servise",
                table: "MedServices",
                newName: "Service");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Service",
                table: "MedServices",
                newName: "Servise");
        }
    }
}
