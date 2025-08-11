using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kamil.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatalogoCentros",
                columns: table => new
                {
                    Numero_Centro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Centro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoCentros", x => x.Numero_Centro);
                });

            migrationBuilder.CreateTable(
                name: "CatalogoPuestos",
                columns: table => new
                {
                    ID_Puesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion_Puesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogoPuestos", x => x.ID_Puesto);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Numero_Empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido_Paterno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido_Materno = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fecha_Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RFC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Directivo = table.Column<bool>(type: "bit", nullable: false),
                    ID_Puesto = table.Column<int>(type: "int", nullable: false),
                    Numero_Centro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Numero_Empleado);
                    table.ForeignKey(
                        name: "FK_Empleados_CatalogoCentros_Numero_Centro",
                        column: x => x.Numero_Centro,
                        principalTable: "CatalogoCentros",
                        principalColumn: "Numero_Centro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empleados_CatalogoPuestos_ID_Puesto",
                        column: x => x.ID_Puesto,
                        principalTable: "CatalogoPuestos",
                        principalColumn: "ID_Puesto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Directivos",
                columns: table => new
                {
                    Numero_Empleado = table.Column<int>(type: "int", nullable: false),
                    Centro_Supervisado = table.Column<int>(type: "int", nullable: false),
                    Prestacion_Combustible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directivos", x => x.Numero_Empleado);
                    table.ForeignKey(
                        name: "FK_Directivos_CatalogoCentros_Centro_Supervisado",
                        column: x => x.Centro_Supervisado,
                        principalTable: "CatalogoCentros",
                        principalColumn: "Numero_Centro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Directivos_Empleados_Numero_Empleado",
                        column: x => x.Numero_Empleado,
                        principalTable: "Empleados",
                        principalColumn: "Numero_Empleado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CatalogoCentros",
                columns: new[] { "Numero_Centro", "Ciudad", "Nombre_Centro" },
                values: new object[,]
                {
                    { 1, "Monterrey", "Centro Norte" },
                    { 2, "Ciudad de México", "Centro Sur" },
                    { 3, "Guadalajara", "Centro Occidente" },
                    { 4, "León", "Centro Bajío" },
                    { 5, "Mérida", "Centro Sureste" }
                });

            migrationBuilder.InsertData(
                table: "CatalogoPuestos",
                columns: new[] { "ID_Puesto", "Descripcion_Puesto" },
                values: new object[,]
                {
                    { 1, "Gerente" },
                    { 2, "Supervisor" },
                    { 3, "Operador" },
                    { 4, "Analista" },
                    { 5, "Administrativo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Directivos_Centro_Supervisado",
                table: "Directivos",
                column: "Centro_Supervisado");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_ID_Puesto",
                table: "Empleados",
                column: "ID_Puesto");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Numero_Centro",
                table: "Empleados",
                column: "Numero_Centro");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_RFC",
                table: "Empleados",
                column: "RFC",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Directivos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "CatalogoCentros");

            migrationBuilder.DropTable(
                name: "CatalogoPuestos");
        }
    }
}
