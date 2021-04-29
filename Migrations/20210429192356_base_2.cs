using Microsoft.EntityFrameworkCore.Migrations;

namespace lab44.Migrations
{
    public partial class base_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kierowca",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMIE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAZWISKO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WIEK = table.Column<int>(type: "int", nullable: false),
                    PLEC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kierowca", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Telefon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAZWA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRODUCENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRTEL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefon", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Zmiana",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KIEROWCAID = table.Column<int>(type: "int", nullable: true),
                    TELEFONID = table.Column<int>(type: "int", nullable: true),
                    SAMOCHODID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zmiana", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Zmiana_Car_SAMOCHODID",
                        column: x => x.SAMOCHODID,
                        principalTable: "Car",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zmiana_Kierowca_KIEROWCAID",
                        column: x => x.KIEROWCAID,
                        principalTable: "Kierowca",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zmiana_Telefon_TELEFONID",
                        column: x => x.TELEFONID,
                        principalTable: "Telefon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zmiana_KIEROWCAID",
                table: "Zmiana",
                column: "KIEROWCAID");

            migrationBuilder.CreateIndex(
                name: "IX_Zmiana_SAMOCHODID",
                table: "Zmiana",
                column: "SAMOCHODID");

            migrationBuilder.CreateIndex(
                name: "IX_Zmiana_TELEFONID",
                table: "Zmiana",
                column: "TELEFONID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zmiana");

            migrationBuilder.DropTable(
                name: "Kierowca");

            migrationBuilder.DropTable(
                name: "Telefon");
        }
    }
}
