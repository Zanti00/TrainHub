using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainHub.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnsToTrainer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Trainer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Trainer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "HourlyRate",
                table: "Trainer",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ImageCapturedDate",
                table: "Trainer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Trainer",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfileImagePath",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SoftDeleteDate",
                table: "Trainer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YearsOfExperience",
                table: "Trainer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "HourlyRate",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "ImageCapturedDate",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "ProfileImagePath",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "SoftDeleteDate",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "YearsOfExperience",
                table: "Trainer");
        }
    }
}
