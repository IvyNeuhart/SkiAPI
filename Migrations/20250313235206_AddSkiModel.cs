using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkiAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSkiModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SkiBrands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SkiBrands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFounded",
                table: "SkiBrands",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "SkiBrandId",
                table: "SkiBrands",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SkiModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkiBrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkiModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkiModel_SkiBrands_SkiBrandId",
                        column: x => x.SkiBrandId,
                        principalTable: "SkiBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkiBrands_SkiBrandId",
                table: "SkiBrands",
                column: "SkiBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_SkiModel_SkiBrandId",
                table: "SkiModel",
                column: "SkiBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkiBrands_SkiBrands_SkiBrandId",
                table: "SkiBrands",
                column: "SkiBrandId",
                principalTable: "SkiBrands",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkiBrands_SkiBrands_SkiBrandId",
                table: "SkiBrands");

            migrationBuilder.DropTable(
                name: "SkiModel");

            migrationBuilder.DropIndex(
                name: "IX_SkiBrands_SkiBrandId",
                table: "SkiBrands");

            migrationBuilder.DropColumn(
                name: "SkiBrandId",
                table: "SkiBrands");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SkiBrands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SkiBrands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFounded",
                table: "SkiBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
