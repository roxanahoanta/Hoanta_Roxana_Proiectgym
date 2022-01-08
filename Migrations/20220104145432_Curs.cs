using Microsoft.EntityFrameworkCore.Migrations;

namespace Hoanta_Roxana_Proiectgym.Migrations
{
    public partial class Curs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AntrenorID",
                table: "Abonament",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CursID",
                table: "Abonament",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Antrenor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ziua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ora = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antrenor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Curs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dificultate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curs", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abonament_AntrenorID",
                table: "Abonament",
                column: "AntrenorID");

            migrationBuilder.CreateIndex(
                name: "IX_Abonament_CursID",
                table: "Abonament",
                column: "CursID");

            migrationBuilder.AddForeignKey(
                name: "FK_Abonament_Antrenor_AntrenorID",
                table: "Abonament",
                column: "AntrenorID",
                principalTable: "Antrenor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Abonament_Curs_CursID",
                table: "Abonament",
                column: "CursID",
                principalTable: "Curs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abonament_Antrenor_AntrenorID",
                table: "Abonament");

            migrationBuilder.DropForeignKey(
                name: "FK_Abonament_Curs_CursID",
                table: "Abonament");

            migrationBuilder.DropTable(
                name: "Antrenor");

            migrationBuilder.DropTable(
                name: "Curs");

            migrationBuilder.DropIndex(
                name: "IX_Abonament_AntrenorID",
                table: "Abonament");

            migrationBuilder.DropIndex(
                name: "IX_Abonament_CursID",
                table: "Abonament");

            migrationBuilder.DropColumn(
                name: "AntrenorID",
                table: "Abonament");

            migrationBuilder.DropColumn(
                name: "CursID",
                table: "Abonament");
        }
    }
}
