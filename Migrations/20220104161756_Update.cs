using Microsoft.EntityFrameworkCore.Migrations;

namespace Hoanta_Roxana_Proiectgym.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Denumire",
                table: "Curs",
                newName: "DenumireCurs");

            migrationBuilder.RenameColumn(
                name: "Prenume",
                table: "Antrenor",
                newName: "PrenumeAntrenor");

            migrationBuilder.RenameColumn(
                name: "Nume",
                table: "Antrenor",
                newName: "NumeAntrenor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DenumireCurs",
                table: "Curs",
                newName: "Denumire");

            migrationBuilder.RenameColumn(
                name: "PrenumeAntrenor",
                table: "Antrenor",
                newName: "Prenume");

            migrationBuilder.RenameColumn(
                name: "NumeAntrenor",
                table: "Antrenor",
                newName: "Nume");
        }
    }
}
