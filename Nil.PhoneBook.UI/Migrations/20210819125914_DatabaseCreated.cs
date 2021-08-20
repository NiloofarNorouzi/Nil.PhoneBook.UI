using Microsoft.EntityFrameworkCore.Migrations;

namespace Nil.PhoneBook.UI.Migrations
{
    public partial class DatabaseCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    PhoneType = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_Phones_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    FavoriteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.FavoriteId);
                    table.ForeignKey(
                        name: "FK_Favorites_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Niloofar", "Norouzi" },
                    { 2, "Alireza", "Norouzi" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "Niloofar", "Norouzi", "123", "n.norouzi" },
                    { 2, "Alireza", "Norouzi", "123", "a.norouzi" }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "FavoriteId", "ContactId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "ContactId", "PhoneNumber", "PhoneType" },
                values: new object[] { 2, 1, "66025634", 1 });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "ContactId", "PhoneNumber", "PhoneType" },
                values: new object[] { 1, 1, "09123018276", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_ContactId",
                table: "Favorites",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_ContactId",
                table: "Phones",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
