using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nera.Web.Migrations
{
    public partial class CompleteBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Rescatistas",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Rescatistas",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Rescatistas",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.CreateTable(
                name: "TipoRescates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRescates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rescates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cliente = table.Column<string>(maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Comentarios = table.Column<string>(nullable: true),
                    TipoRescateId = table.Column<int>(nullable: true),
                    RescatistaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rescates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rescates_Rescatistas_RescatistaID",
                        column: x => x.RescatistaID,
                        principalTable: "Rescatistas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rescates_TipoRescates_TipoRescateId",
                        column: x => x.TipoRescateId,
                        principalTable: "TipoRescates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroRescates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Comentarios = table.Column<string>(nullable: true),
                    Odometro = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    VehiculoId = table.Column<int>(nullable: true),
                    RescateId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroRescates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroRescates_Rescates_RescateId",
                        column: x => x.RescateId,
                        principalTable: "Rescates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegistroRescates_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistroRescates_RescateId",
                table: "RegistroRescates",
                column: "RescateId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroRescates_VehiculoId",
                table: "RegistroRescates",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Rescates_RescatistaID",
                table: "Rescates",
                column: "RescatistaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rescates_TipoRescateId",
                table: "Rescates",
                column: "TipoRescateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroRescates");

            migrationBuilder.DropTable(
                name: "Rescates");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "TipoRescates");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Rescatistas",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Rescatistas",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Rescatistas",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);
        }
    }
}
