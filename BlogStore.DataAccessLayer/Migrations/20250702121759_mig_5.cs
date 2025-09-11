using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogStore.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsToxic",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "ToxicityScore",
                table: "Comments",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsToxic",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ToxicityScore",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Articles");
        }
    }
}
