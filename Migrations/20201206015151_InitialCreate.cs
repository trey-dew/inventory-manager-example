using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace inventory_managemnt_system.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNum = table.Column<int>(nullable: false),
                    RoomNum = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    operatingSystem = table.Column<string>(nullable: true),
                    owner = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computer", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computer");
        }
    }
}
