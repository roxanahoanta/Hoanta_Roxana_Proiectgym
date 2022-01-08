using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hoanta_Roxana_Proiectgym.Migrations
{
    public partial class DataCreareAbonament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Abonament",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCreareAbonament",
                table: "Abonament",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCreareAbonament",
                table: "Abonament");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Abonament",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");
        }
    }
}
