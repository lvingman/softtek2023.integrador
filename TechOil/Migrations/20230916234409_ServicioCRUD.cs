using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechOil.Migrations
{
    public partial class ServicioCRUD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Servicios",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "Administrador del proyecto", "Administrador" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "Consultor del proyecto", "Consultor" });

            migrationBuilder.InsertData(
                table: "Servicios",
                columns: new[] { "Id", "Descripcion", "Estado", "ValorHora" },
                values: new object[,]
                {
                    { 1, "Un servicio", true, 37.5 },
                    { 2, "Servicio Nº2", true, 80.75 }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Contrasena",
                value: "65868a13c24d6ac4c36e32168b803d5f0ebdd1281f214d405589eb80d15457e8");

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Active", "Contrasena", "Dni", "Email", "IdRol", "Nombre" },
                values: new object[] { 2, true, "4a69309de6f62fa45408c5dd0c121d262cb47a5e6e35d7a6ac7914171c24b638", "41024562", "test2@test.org", 2, "testuser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Servicios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "Consulta", "Consulta" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Contrasena",
                value: "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4");
        }
    }
}
