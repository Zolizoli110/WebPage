using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class NewsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_AuthorId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "DisplayName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Reservations",
                newName: "Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_AuthorId",
                table: "Reservations",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_AuthorId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Reservations",
                newName: "Text");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_AuthorId",
                table: "Reservations",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
