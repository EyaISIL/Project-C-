using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Add_produits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produits",
                columns: table => new
                {
                    computerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brand = table.Column<string>(nullable: true),
                    Processor = table.Column<int>(nullable: true),
                    HardDisk = table.Column<int>(nullable: true),
                    MemoryRAM = table.Column<int>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                     Price= table.Column<int>(nullable: true),
                   OS= table.Column<string>(nullable: true),
                   color= table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produits", x => x.computerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produits");
        }
    }
}
