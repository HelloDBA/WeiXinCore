using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeiXinCore.Migrations
{
    public partial class DBInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VERB",
                columns: table => new
                {
                    memberID = table.Column<string>(maxLength: 32, nullable: false),
                    Token = table.Column<string>(maxLength: 32, nullable: true),
                    modDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VERB", x => x.memberID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VERB");
        }
    }
}
