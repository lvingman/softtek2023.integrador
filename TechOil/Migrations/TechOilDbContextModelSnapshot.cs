﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechOil.DataAccess;

#nullable disable

namespace TechOil.Migrations
{
    [DbContext(typeof(TechOilDbContext))]
    partial class TechOilDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TechOil.Models.Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("Direccion");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Proyectos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Direccion = "P. Sherman, Calle Wallaby 42",
                            IdEstado = 1,
                            Nombre = "Proyecto 1"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Direccion = "Avenida Siempre Viva 742",
                            IdEstado = 2,
                            Nombre = "Proyecto 2"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Direccion = "Mariano Moreno 3311",
                            IdEstado = 3,
                            Nombre = "Proyecto 3"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            Direccion = "Guemes 1645",
                            IdEstado = 1,
                            Nombre = "Proyecto 4"
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            Direccion = "Gaspar Campos 3200",
                            IdEstado = 2,
                            Nombre = "Proyecto 5"
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            Direccion = "Avenida Corrientes y Libertador",
                            IdEstado = 3,
                            Nombre = "Proyecto 6"
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            Direccion = "Ruta 197 y Yrigoin",
                            IdEstado = 1,
                            Nombre = "Proyecto 7"
                        },
                        new
                        {
                            Id = 8,
                            Active = true,
                            Direccion = "Avenida Balbin 433",
                            IdEstado = 2,
                            Nombre = "Proyecto 8"
                        },
                        new
                        {
                            Id = 9,
                            Active = true,
                            Direccion = "Parana 350",
                            IdEstado = 3,
                            Nombre = "Proyecto 9"
                        },
                        new
                        {
                            Id = 10,
                            Active = true,
                            Direccion = "Sarmiento 1888",
                            IdEstado = 1,
                            Nombre = "Proyecto 10"
                        },
                        new
                        {
                            Id = 11,
                            Active = true,
                            Direccion = "Gutierrez 4011",
                            IdEstado = 2,
                            Nombre = "Proyecto 11"
                        },
                        new
                        {
                            Id = 12,
                            Active = true,
                            Direccion = "Avenida Corrientes 6200",
                            IdEstado = 3,
                            Nombre = "Proyecto 12"
                        });
                });

            modelBuilder.Entity("TechOil.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("Active");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Descripcion = "Administrador del proyecto",
                            Nombre = "Administrador"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Descripcion = "Consultor del proyecto",
                            Nombre = "Consultor"
                        });
                });

            modelBuilder.Entity("TechOil.Models.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Descripcion");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("Estado");

                    b.Property<double>("ValorHora")
                        .HasColumnType("float")
                        .HasColumnName("ValorHora");

                    b.HasKey("Id");

                    b.ToTable("Servicios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Servicio Nº1",
                            Estado = true,
                            ValorHora = 37.5
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Servicio Nº2",
                            Estado = true,
                            ValorHora = 80.75
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Servicio Nº3",
                            Estado = true,
                            ValorHora = 4000.0
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Servicio Nº4",
                            Estado = true,
                            ValorHora = 999.99000000000001
                        },
                        new
                        {
                            Id = 5,
                            Descripcion = "Servicio Nº5",
                            Estado = true,
                            ValorHora = 1000.1
                        },
                        new
                        {
                            Id = 6,
                            Descripcion = "Servicio Nº6",
                            Estado = true,
                            ValorHora = 1337.3
                        },
                        new
                        {
                            Id = 7,
                            Descripcion = "Servicio Nº7",
                            Estado = true,
                            ValorHora = 50.5
                        },
                        new
                        {
                            Id = 8,
                            Descripcion = "Servicio Nº8",
                            Estado = true,
                            ValorHora = 200.19999999999999
                        },
                        new
                        {
                            Id = 9,
                            Descripcion = "Servicio Nº9",
                            Estado = true,
                            ValorHora = 1.0
                        },
                        new
                        {
                            Id = 10,
                            Descripcion = "Servicio Nº10",
                            Estado = true,
                            ValorHora = 22.0
                        },
                        new
                        {
                            Id = 11,
                            Descripcion = "Servicio Nº11",
                            Estado = true,
                            ValorHora = 777.0
                        },
                        new
                        {
                            Id = 12,
                            Descripcion = "Servicio Nº12",
                            Estado = true,
                            ValorHora = 199.97999999999999
                        });
                });

            modelBuilder.Entity("TechOil.Models.Trabajo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("Active");

                    b.Property<int>("CantidadHoras")
                        .HasColumnType("int")
                        .HasColumnName("CantidadHoras");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProyecto")
                        .HasColumnType("int");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int");

                    b.Property<double>("ValorHora")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdProyecto");

                    b.HasIndex("IdServicio");

                    b.ToTable("Trabajos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CantidadHoras = 8,
                            Costo = 100.0,
                            Fecha = new DateTime(1998, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 1,
                            IdServicio = 1,
                            ValorHora = 12.5
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CantidadHoras = 4,
                            Costo = 130.19999999999999,
                            Fecha = new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 2,
                            IdServicio = 2,
                            ValorHora = 32.549999999999997
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CantidadHoras = 8,
                            Costo = 34400.0,
                            Fecha = new DateTime(2015, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 5,
                            IdServicio = 3,
                            ValorHora = 4300.0
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CantidadHoras = 6,
                            Costo = 5310.0,
                            Fecha = new DateTime(2007, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 7,
                            IdServicio = 5,
                            ValorHora = 885.0
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            CantidadHoras = 2,
                            Costo = 125.0,
                            Fecha = new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 8,
                            IdServicio = 8,
                            ValorHora = 62.5
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            CantidadHoras = 8,
                            Costo = 76000.0,
                            Fecha = new DateTime(1990, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 1,
                            IdServicio = 5,
                            ValorHora = 9500.0
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            CantidadHoras = 7,
                            Costo = 599.34000000000003,
                            Fecha = new DateTime(2011, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 10,
                            IdServicio = 10,
                            ValorHora = 85.620000000000005
                        },
                        new
                        {
                            Id = 8,
                            Active = true,
                            CantidadHoras = 6,
                            Costo = 1035.0,
                            Fecha = new DateTime(2001, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 5,
                            IdServicio = 4,
                            ValorHora = 172.5
                        },
                        new
                        {
                            Id = 9,
                            Active = true,
                            CantidadHoras = 8,
                            Costo = 724.0,
                            Fecha = new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 9,
                            IdServicio = 8,
                            ValorHora = 90.5
                        },
                        new
                        {
                            Id = 10,
                            Active = true,
                            CantidadHoras = 6,
                            Costo = 598.23000000000002,
                            Fecha = new DateTime(2005, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 5,
                            IdServicio = 5,
                            ValorHora = 99.704999999999998
                        },
                        new
                        {
                            Id = 11,
                            Active = true,
                            CantidadHoras = 12,
                            Costo = 120.0,
                            Fecha = new DateTime(2002, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdProyecto = 6,
                            IdServicio = 9,
                            ValorHora = 10.0
                        });
                });

            modelBuilder.Entity("TechOil.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("Active");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("VARCHAR(64)")
                        .HasColumnName("Contrasena");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("Dni");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("Email");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("IdRol");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Contrasena = "65868a13c24d6ac4c36e32168b803d5f0ebdd1281f214d405589eb80d15457e8",
                            Dni = "41024562",
                            Email = "test@test.org",
                            IdRol = 1,
                            Nombre = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Contrasena = "4a69309de6f62fa45408c5dd0c121d262cb47a5e6e35d7a6ac7914171c24b638",
                            Dni = "2123422",
                            Email = "test2@test.org",
                            IdRol = 2,
                            Nombre = "consultor1"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Contrasena = "e58d82c6770d838386292c6a83335a8f0740f852b10dc0c7cb8955c4722372ad",
                            Dni = "40412401",
                            Email = "test3@test.org",
                            IdRol = 2,
                            Nombre = "consultor2"
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            Contrasena = "a66a91cfb88db66ba89db78cc34172de3afbae14609eda98553dd4c3e7d8e2dd",
                            Dni = "33101222",
                            Email = "test4@test.org",
                            IdRol = 2,
                            Nombre = "consultor3"
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            Contrasena = "2509a6c5b78cccbe38f4ea556e5b7f39696cd44dfdc1927267901514c812e593",
                            Dni = "11111111",
                            Email = "test5@test.org",
                            IdRol = 2,
                            Nombre = "consultor4"
                        },
                        new
                        {
                            Id = 6,
                            Active = true,
                            Contrasena = "547d7cd606043351a8ce1b531c58c47c9ce018fefd0c6417a80dce68c7899b4f",
                            Dni = "22111222",
                            Email = "test6@test.org",
                            IdRol = 2,
                            Nombre = "consultor5"
                        },
                        new
                        {
                            Id = 7,
                            Active = true,
                            Contrasena = "0bddec89aaec5e2adfe652d02577976259c5a427ab19e039ba9f460a9f166688",
                            Dni = "33333111",
                            Email = "test7@test.org",
                            IdRol = 2,
                            Nombre = "consultor6"
                        },
                        new
                        {
                            Id = 8,
                            Active = true,
                            Contrasena = "3e6c31d68c2488caeadded9aa60e8b9ae8cc233f84c6844ddb6926707987ee0b",
                            Dni = "12123123",
                            Email = "test8@test.org",
                            IdRol = 2,
                            Nombre = "consultor7"
                        },
                        new
                        {
                            Id = 9,
                            Active = true,
                            Contrasena = "6ffb3b31ba592be93ea8f2cbf2f8751b1752ee13e019df1a4315855783d873b0",
                            Dni = "22333222",
                            Email = "test9@test.org",
                            IdRol = 2,
                            Nombre = "consultor8"
                        },
                        new
                        {
                            Id = 10,
                            Active = true,
                            Contrasena = "1bd97e0e6538860b2dea71705db43f9eceb1c26ef023dc67ea936c80d37ce7ef",
                            Dni = "22111333",
                            Email = "test10@test.org",
                            IdRol = 2,
                            Nombre = "consultor9"
                        },
                        new
                        {
                            Id = 11,
                            Active = true,
                            Contrasena = "03acc8826bebb8e9a204ec086dd4edcf806dd48fe235be2da1ebe5c1692c1088",
                            Dni = "22222111",
                            Email = "test11@test.org",
                            IdRol = 2,
                            Nombre = "consultor10"
                        },
                        new
                        {
                            Id = 12,
                            Active = true,
                            Contrasena = "a9221cc1aa09b8ec5fcaa6c1edbc4e4d4523961685be7902f98b746e49cddb2f",
                            Dni = "11333555",
                            Email = "test12@test.org",
                            IdRol = 2,
                            Nombre = "consultor11"
                        },
                        new
                        {
                            Id = 13,
                            Active = true,
                            Contrasena = "b5508200f464d21aee01723ce8ca6628b6e3a480c6bb5d67da6bb3d34825dd49",
                            Dni = "40412412",
                            Email = "test13@test.org",
                            IdRol = 2,
                            Nombre = "consultor12"
                        });
                });

            modelBuilder.Entity("TechOil.Models.Trabajo", b =>
                {
                    b.HasOne("TechOil.Models.Proyecto", "Proyecto")
                        .WithMany()
                        .HasForeignKey("IdProyecto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechOil.Models.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("IdServicio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("TechOil.Models.Usuario", b =>
                {
                    b.HasOne("TechOil.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}
