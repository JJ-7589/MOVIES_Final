using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.W.Movies.Migrations
{
    /// <inheritdoc />
    public partial class Definitiva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "Categories",
                newName: "ModidyedDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Categories",
                newName: "CreationsDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModidyedDate",
                table: "Categories",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "CreationsDate",
                table: "Categories",
                newName: "CreatedDate");
        }
    }
}
