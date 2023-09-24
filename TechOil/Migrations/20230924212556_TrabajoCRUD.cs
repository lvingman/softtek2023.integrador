using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechOil.Migrations
{
    public partial class TrabajoCRUD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Trabajos",
                newName: "Fecha");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha",
                table: "Trabajos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Trabajos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Proyectos",
                columns: new[] { "Id", "Active", "Direccion", "IdEstado", "Nombre" },
                values: new object[,]
                {
                    { 3, true, "Mariano Moreno 3311", 3, "Proyecto 3" },
                    { 4, true, "Guemes 1645", 1, "Proyecto 4" },
                    { 5, true, "Gaspar Campos 3200", 2, "Proyecto 5" },
                    { 6, true, "Avenida Corrientes y Libertador", 3, "Proyecto 6" },
                    { 7, true, "Ruta 197 y Yrigoin", 1, "Proyecto 7" },
                    { 8, true, "Avenida Balbin 433", 2, "Proyecto 8" },
                    { 9, true, "Parana 350", 3, "Proyecto 9" },
                    { 10, true, "Sarmiento 1888", 1, "Proyecto 10" },
                    { 11, true, "Gutierrez 4011", 2, "Proyecto 11" },
                    { 12, true, "Avenida Corrientes 6200", 3, "Proyecto 12" }
                });

            migrationBuilder.UpdateData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descripcion",
                value: "Servicio Nº1");

            migrationBuilder.InsertData(
                table: "Servicios",
                columns: new[] { "Id", "Descripcion", "Estado", "ValorHora" },
                values: new object[,]
                {
                    { 3, "Servicio Nº3", true, 4000.0 },
                    { 4, "Servicio Nº4", true, 999.99000000000001 },
                    { 5, "Servicio Nº5", true, 1000.1 },
                    { 6, "Servicio Nº6", true, 1337.3 },
                    { 7, "Servicio Nº7", true, 50.5 },
                    { 8, "Servicio Nº8", true, 200.19999999999999 },
                    { 9, "Servicio Nº9", true, 1.0 },
                    { 10, "Servicio Nº10", true, 22.0 },
                    { 11, "Servicio Nº11", true, 777.0 },
                    { 12, "Servicio Nº12", true, 199.97999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Trabajos",
                columns: new[] { "Id", "Active", "CantidadHoras", "Costo", "Fecha", "IdProyecto", "IdServicio", "ValorHora" },
                values: new object[,]
                {
                    { 1, true, 8, 100.0, new DateTime(1998, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 12.5 },
                    { 2, true, 4, 130.19999999999999, new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 32.549999999999997 }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dni", "Nombre" },
                values: new object[] { "2123422", "consultor1" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Active", "Contrasena", "Dni", "Email", "IdRol", "Nombre" },
                values: new object[,]
                {
                    { 3, true, "e58d82c6770d838386292c6a83335a8f0740f852b10dc0c7cb8955c4722372ad", "40412401", "test3@test.org", 2, "consultor2" },
                    { 4, true, "a66a91cfb88db66ba89db78cc34172de3afbae14609eda98553dd4c3e7d8e2dd", "33101222", "test4@test.org", 2, "consultor3" },
                    { 5, true, "2509a6c5b78cccbe38f4ea556e5b7f39696cd44dfdc1927267901514c812e593", "11111111", "test5@test.org", 2, "consultor4" },
                    { 6, true, "547d7cd606043351a8ce1b531c58c47c9ce018fefd0c6417a80dce68c7899b4f", "22111222", "test6@test.org", 2, "consultor5" },
                    { 7, true, "0bddec89aaec5e2adfe652d02577976259c5a427ab19e039ba9f460a9f166688", "33333111", "test7@test.org", 2, "consultor6" },
                    { 8, true, "3e6c31d68c2488caeadded9aa60e8b9ae8cc233f84c6844ddb6926707987ee0b", "12123123", "test8@test.org", 2, "consultor7" },
                    { 9, true, "6ffb3b31ba592be93ea8f2cbf2f8751b1752ee13e019df1a4315855783d873b0", "22333222", "test9@test.org", 2, "consultor8" },
                    { 10, true, "1bd97e0e6538860b2dea71705db43f9eceb1c26ef023dc67ea936c80d37ce7ef", "22111333", "test10@test.org", 2, "consultor9" },
                    { 11, true, "03acc8826bebb8e9a204ec086dd4edcf806dd48fe235be2da1ebe5c1692c1088", "22222111", "test11@test.org", 2, "consultor10" },
                    { 12, true, "a9221cc1aa09b8ec5fcaa6c1edbc4e4d4523961685be7902f98b746e49cddb2f", "11333555", "test12@test.org", 2, "consultor11" },
                    { 13, true, "b5508200f464d21aee01723ce8ca6628b6e3a480c6bb5d67da6bb3d34825dd49", "40412412", "test13@test.org", 2, "consultor12" }
                });

            migrationBuilder.InsertData(
                table: "Trabajos",
                columns: new[] { "Id", "Active", "CantidadHoras", "Costo", "Fecha", "IdProyecto", "IdServicio", "ValorHora" },
                values: new object[,]
                {
                    { 3, true, 8, 34400.0, new DateTime(2015, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, 4300.0 },
                    { 4, true, 6, 5310.0, new DateTime(2007, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 5, 885.0 },
                    { 5, true, 2, 125.0, new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 8, 62.5 },
                    { 6, true, 8, 76000.0, new DateTime(1990, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, 9500.0 },
                    { 7, true, 7, 599.34000000000003, new DateTime(2011, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 10, 85.620000000000005 },
                    { 8, true, 6, 1035.0, new DateTime(2001, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, 172.5 },
                    { 9, true, 8, 724.0, new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 8, 90.5 },
                    { 10, true, 6, 598.23000000000002, new DateTime(2005, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, 99.704999999999998 },
                    { 11, true, 12, 120.0, new DateTime(2002, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 9, 10.0 }
                });

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
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trabajos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Proyectos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Trabajos");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Trabajos",
                newName: "Nombre");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Nombre",
                table: "Trabajos",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descripcion",
                value: "Un servicio");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "rmartin");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dni", "Nombre" },
                values: new object[] { "41024562", "testuser" });
        }
    }
}
