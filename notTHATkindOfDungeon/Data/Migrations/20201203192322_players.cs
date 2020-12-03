using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace notTHATkindOfDungeon.Data.Migrations
{
    public partial class players : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attack = table.Column<int>(nullable: false),
                    CurrentHitPoints = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    FilledInventorySpaces = table.Column<int>(nullable: false),
                    GameProgress = table.Column<int>(nullable: false),
                    GoldPieces = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    TotalHitpoints = table.Column<int>(nullable: false),
                    TotalInventorySpaces = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
