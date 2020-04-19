using Microsoft.EntityFrameworkCore.Migrations;

namespace AppWeb.Data.Migrations
{
    public partial class Agregar_Clients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dnom = table.Column<string>(nullable: false),
                    maildnom = table.Column<string>(nullable: true),
                    userwd = table.Column<string>(nullable: true),
                    passwd = table.Column<string>(nullable: true),
                    accewd = table.Column<string>(nullable: true),
                    userht = table.Column<string>(nullable: true),
                    passht = table.Column<string>(nullable: true),
                    lnkht = table.Column<string>(nullable: true),
                    dobs = table.Column<string>(nullable: true),
                    est = table.Column<string>(nullable: true),
                    dobsest = table.Column<string>(nullable: true),
                    presu = table.Column<string>(nullable: true),
                    ppresu = table.Column<string>(nullable: true),
                    fpag = table.Column<string>(nullable: true),
                    phtheme = table.Column<string>(nullable: true),
                    climent = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
