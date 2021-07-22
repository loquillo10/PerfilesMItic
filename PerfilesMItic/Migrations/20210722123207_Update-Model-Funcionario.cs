using Microsoft.EntityFrameworkCore.Migrations;

namespace PerfilesMItic.Migrations
{
    public partial class UpdateModelFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vivienda",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vivienda",
                table: "Funcionario");
        }
    }
}
