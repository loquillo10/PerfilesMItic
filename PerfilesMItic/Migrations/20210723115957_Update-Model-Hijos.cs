using Microsoft.EntityFrameworkCore.Migrations;

namespace PerfilesMItic.Migrations
{
    public partial class UpdateModelHijos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cedulaH",
                table: "Hijo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cedulaH",
                table: "Hijo");
        }
    }
}
