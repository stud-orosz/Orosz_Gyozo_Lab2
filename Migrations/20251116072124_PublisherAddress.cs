using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orosz_Gyozo_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class PublisherAdress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublisherAdress",
                table: "Publisher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherAdress",
                table: "Publisher");
        }
    }
}
