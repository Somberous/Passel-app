using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Passel.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "Changes",
                columns: table => new
                {
                    ChangeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeType = table.Column<string>(nullable: false),
                    ChangeDescription = table.Column<string>(nullable: true),
                    ChangeDate = table.Column<DateTime>(nullable: false),
                    ChangeAuthor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Changes", x => x.ChangeID);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    MediaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaType = table.Column<string>(nullable: true),
                    MediaName = table.Column<string>(nullable: true),
                    MediaURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.MediaID);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountID", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "test@test.comm", "test" },
                    { 2, "test1@test.com", "test1" }
                });

            migrationBuilder.InsertData(
                table: "Changes",
                columns: new[] { "ChangeID", "ChangeAuthor", "ChangeDate", "ChangeDescription", "ChangeType" },
                values: new object[,]
                {
                    { 1, "Ayden Masters", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Added new look to home page.", "Add Feature" },
                    { 2, "Ayden Masters", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Added new Change Log page to the site.", "Add Feature" },
                    { 3, "Ayden Masters", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Added new Add Application page to the site.", "Add Feature" },
                    { 4, "Ayden Masters", new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Started working on implementing the login page.", "Add Feature" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "MediaID", "MediaName", "MediaType", "MediaURL" },
                values: new object[,]
                {
                    { 1, "YouTube", "Entertainment", "https://www.youtube.com/" },
                    { 2, "Netflix", "Entertainment", "https://www.netflix.com/" },
                    { 3, "Hulu", "Entertainment", "https://www.hulu.com/" },
                    { 4, "Twitter", "Social Media", "https://twitter.com/" },
                    { 5, "Facebook", "Social Media", "https://www.facebook.com/" },
                    { 6, "Reddit", "Social Media", "https://www.reddit.com/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Changes");

            migrationBuilder.DropTable(
                name: "Medias");
        }
    }
}
