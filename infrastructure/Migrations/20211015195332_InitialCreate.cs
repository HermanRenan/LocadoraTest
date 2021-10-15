using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal", nullable: false),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEdit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rented = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
