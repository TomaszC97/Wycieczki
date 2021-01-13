using Microsoft.EntityFrameworkCore.Migrations;

namespace Wycieczki.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wycieczki",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    poczatekTrasy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    konieTrasy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataWycieczki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pokonanyDystans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    liczbaDni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zdjecie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    video = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wycieczki", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wycieczki");
        }
    }
}
