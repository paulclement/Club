using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace PClement.Club.Migrations.ClubDb
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Club");
        }
    }
}
