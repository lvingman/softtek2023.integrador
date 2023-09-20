using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechOil.Migrations
{
    public partial class CRUDTrabajo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Proyectos",
                newName: "IdEstado");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Trabajos",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Trabajos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Proyectos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Proyectos",
                columns: new[] { "Id", "Active", "Direccion", "IdEstado", "Nombre" },
                values: new object[] { 1, true, "P. Sherman, Calle Wallaby 42", 1, "Proyecto 1" });

            migrationBuilder.InsertData(
                table: "Proyectos",
                columns: new[] { "Id", "Active", "Direccion", "IdEstado", "Nombre" },
                values: new object[] { 2, true, "Avenida Siempre Viva 742", 2, "Proyecto 2" });

            migrationBuilder.InsertData(
                table: "Trabajos",
                columns: new[] { "Id", "Active", "CantidadHoras", "Costo", "Nombre", "IdProyecto", "IdServicio", "ValorHora" },
                values: new object[] { 1, true, 8, 3000.0, "12/03/1998", 1, 1, 12.5 });

            migrationBuilder.InsertData(
                table: "Trabajos",
                columns: new[] { "Id", "Active", "CantidadHoras", "Costo", "Nombre", "IdProyecto", "IdServicio", "ValorHora" },
                values: new object[] { 2, true, 4, 200000.0, "22/01/2020", 2, 2, 32.549999999999997 });

            migrationBuilder.CreateIndex(
                name: "IX_Trabajos_IdProyecto",
                table: "Trabajos",
                column: "IdProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajos_IdServicio",
                table: "Trabajos",
                column: "IdServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_Trabajos_Proyectos_IdProyecto",
                table: "Trabajos",
                column: "IdProyecto",
                principalTable: "Proyectos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trabajos_Servicios_IdServicio",
                table: "Trabajos",
                column: "IdServicio",
                principalTable: "Servicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trabajos_Proyectos_IdProyecto",
                table: "Trabajos");

            migrationBuilder.DropForeignKey(
                name: "FK_Trabajos_Servicios_IdServicio",
                table: "Trabajos");

            migrationBuilder.DropIndex(
                name: "IX_Trabajos_IdProyecto",
                table: "Trabajos");

            migrationBuilder.DropIndex(
                name: "IX_Trabajos_IdServicio",
                table: "Trabajos");

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Trabajos");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Proyectos");

            migrationBuilder.RenameColumn(
                name: "IdEstado",
                table: "Proyectos",
                newName: "Estado");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Nombre",
                table: "Trabajos",
                type: "Date",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");
        }
    }
}
