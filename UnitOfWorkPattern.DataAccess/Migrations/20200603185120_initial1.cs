using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitOfWorkPattern.DataAccess.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Kategoris");

            migrationBuilder.DropColumn(
                name: "KategoriName",
                table: "Kategoris");

            migrationBuilder.AddColumn<DateTime>(
                name: "OlusturmaTarihi",
                table: "Uruns",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Adi",
                table: "Kategoris",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OlusturmaTarihi",
                table: "Kategoris",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OlusturmaTarihi",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "Adi",
                table: "Kategoris");

            migrationBuilder.DropColumn(
                name: "OlusturmaTarihi",
                table: "Kategoris");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Uruns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Kategoris",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "KategoriName",
                table: "Kategoris",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
