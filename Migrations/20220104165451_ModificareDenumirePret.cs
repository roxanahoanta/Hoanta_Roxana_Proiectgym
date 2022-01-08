using Microsoft.EntityFrameworkCore.Migrations;

namespace Hoanta_Roxana_Proiectgym.Migrations
{
    public partial class ModificareDenumirePret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Abonament",
                newName: "Pret");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pret",
                table: "Abonament",
                newName: "Price");
        }
    }
}
