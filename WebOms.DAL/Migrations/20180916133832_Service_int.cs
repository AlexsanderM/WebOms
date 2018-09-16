using Microsoft.EntityFrameworkCore.Migrations;

namespace WebOms.DAL.Migrations
{
    public partial class Service_int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Service",
                table: "MedServices",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Service",
                table: "MedServices",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
