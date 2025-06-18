using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainHub.Migrations
{
    /// <inheritdoc />
    public partial class AddMobileNumberColumnToTrainerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Trainer");
        }
    }
}
