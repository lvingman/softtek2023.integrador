using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechOil.Migrations
{
    public partial class AgregaRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Usuarios",
                newName: "IdRol");

            migrationBuilder.AlterColumn<string>(
                name: "Contrasena",
                table: "Usuarios",
                type: "VARCHAR(64)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Active", "Descripcion", "Nombre" },
                values: new object[] { 1, true, "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Active", "Descripcion", "Nombre" },
                values: new object[] { 2, true, "Consulta", "Consulta" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Contrasena",
                value: "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Roles_RolId",
                table: "Usuarios",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Roles_RolId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "IdRol",
                table: "Usuarios",
                newName: "Tipo");

            migrationBuilder.AlterColumn<string>(
                name: "Contrasena",
                table: "Usuarios",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(64)");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Contrasena",
                value: "1234");
        }
    }
}
