using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainHub.Migrations
{
    /// <inheritdoc />
    public partial class AddGenderAndRemoveExpiryDatesColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysToExpiry",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Member");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Member");

            migrationBuilder.AddColumn<int>(
                name: "DaysToExpiry",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "Member",
                type: "datetime2",
                nullable: true);
        }
    }
}
