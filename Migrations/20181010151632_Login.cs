using Microsoft.EntityFrameworkCore.Migrations;

namespace hackme.Migrations
{
    public partial class Login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Password);
                });

            migrationBuilder.InsertData(
                table: "Logins",
                column: "Password",
                value: "e6895616-4b86-4be3-9450-26fbb8a0f605");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");
        }
    }
}
