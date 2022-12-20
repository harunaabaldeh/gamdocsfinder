using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class updatedDocumentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Documents",
                newName: "OwnerFullName");

            migrationBuilder.RenameColumn(
                name: "FounderName",
                table: "Documents",
                newName: "FounderPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Documents",
                newName: "FounderFullName");

            migrationBuilder.AddColumn<string>(
                name: "FounderAddress",
                table: "Documents",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FounderAddress",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "OwnerFullName",
                table: "Documents",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FounderPhoneNumber",
                table: "Documents",
                newName: "FounderName");

            migrationBuilder.RenameColumn(
                name: "FounderFullName",
                table: "Documents",
                newName: "FirstName");
        }
    }
}
