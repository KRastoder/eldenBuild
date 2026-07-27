using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldenBuilds.Api.Migrations
{
    /// <inheritdoc />
    public partial class StatSpreadMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatSpread",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Vigor = table.Column<int>(type: "int", nullable: false),
                    Mind = table.Column<int>(type: "int", nullable: false),
                    Endurance = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Arcane = table.Column<int>(type: "int", nullable: false),
                    Faith = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatSpread", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatSpread");
        }
    }
}
