using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainHub.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmailColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Trainer",
                newName: "Email");

            migrationBuilder.AlterColumn<string>(
                name: "YearsOfExperience",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Trainer",
                newName: "EmailAddress");

            migrationBuilder.AlterColumn<int>(
                name: "YearsOfExperience",
                table: "Trainer",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
