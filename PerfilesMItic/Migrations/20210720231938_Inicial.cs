using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PerfilesMItic.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailParticular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    TelefonoMovil = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Pasaporte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegConducir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RUC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCiudad = table.Column<int>(type: "int", nullable: false),
                    IdBarrio = table.Column<int>(type: "int", nullable: false),
                    IdDepartamento = table.Column<int>(type: "int", nullable: false),
                    IdPais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.IdFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "Barrio",
                columns: table => new
                {
                    IdBarrio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barrio", x => x.IdBarrio);
                    table.ForeignKey(
                        name: "FK_Barrio_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conyuge",
                columns: table => new
                {
                    IdConyuge = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SexoC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CedulaC = table.Column<int>(type: "int", nullable: false),
                    TelefonoC = table.Column<int>(type: "int", nullable: false),
                    CelularC = table.Column<int>(type: "int", nullable: false),
                    IdFuncionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conyuge", x => x.IdConyuge);
                    table.ForeignKey(
                        name: "FK_Conyuge_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Familiar",
                columns: table => new
                {
                    IdFamiliar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoFamiliar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdFuncionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familiar", x => x.IdFamiliar);
                    table.ForeignKey(
                        name: "FK_Familiar_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FuncionPublica",
                columns: table => new
                {
                    IdFuncionPublica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreFP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoFP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdFuncionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionPublica", x => x.IdFuncionPublica);
                    table.ForeignKey(
                        name: "FK_FuncionPublica_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hijo",
                columns: table => new
                {
                    IdHijo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimientoH = table.Column<DateTime>(type: "datetime2", nullable: true),
                    cantidadHijos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdFuncionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hijo", x => x.IdHijo);
                    table.ForeignKey(
                        name: "FK_Hijo_Funcionario_IdFuncionario",
                        column: x => x.IdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    IdPais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.IdPais);
                    table.ForeignKey(
                        name: "FK_Pais_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    IdCiudad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarioIdBarrio = table.Column<int>(type: "int", nullable: true),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.IdCiudad);
                    table.ForeignKey(
                        name: "FK_Ciudad_Barrio_BarioIdBarrio",
                        column: x => x.BarioIdBarrio,
                        principalTable: "Barrio",
                        principalColumn: "IdBarrio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ciudad_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    IdDepartamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiudadIdCiudad = table.Column<int>(type: "int", nullable: true),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.IdDepartamento);
                    table.ForeignKey(
                        name: "FK_Departamento_Ciudad_CiudadIdCiudad",
                        column: x => x.CiudadIdCiudad,
                        principalTable: "Ciudad",
                        principalColumn: "IdCiudad",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departamento_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barrio_FuncionarioId",
                table: "Barrio",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_BarioIdBarrio",
                table: "Ciudad",
                column: "BarioIdBarrio");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_FuncionarioId",
                table: "Ciudad",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Conyuge_IdFuncionario",
                table: "Conyuge",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_CiudadIdCiudad",
                table: "Departamento",
                column: "CiudadIdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_FuncionarioId",
                table: "Departamento",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Familiar_IdFuncionario",
                table: "Familiar",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionPublica_IdFuncionario",
                table: "FuncionPublica",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Hijo_IdFuncionario",
                table: "Hijo",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Pais_FuncionarioId",
                table: "Pais",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conyuge");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Familiar");

            migrationBuilder.DropTable(
                name: "FuncionPublica");

            migrationBuilder.DropTable(
                name: "Hijo");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "Barrio");

            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
