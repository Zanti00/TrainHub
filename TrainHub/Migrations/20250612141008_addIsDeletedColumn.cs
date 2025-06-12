using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainHub.Migrations
{
    /// <inheritdoc />
    public partial class addIsDeletedColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Member");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Member",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Member");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Member",
                type: "datetime2",
                nullable: true);
        }
    }
}
