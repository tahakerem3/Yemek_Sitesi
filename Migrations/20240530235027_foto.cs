using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AhtapotRecipe.Migrations
{
    /// <inheritdoc />
    public partial class foto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YemekFoto",
                table: "Tarif",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YemekFoto",
                table: "Tarif");
        }
    }
}
