using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechOil.Migrations
{
    public partial class ProyectoCRUD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Proyectos",
                newName: "IdEstado");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Proyectos");

            migrationBuilder.RenameColumn(
                name: "IdEstado",
                table: "Proyectos",
                newName: "Estado");
        }
    }
}
