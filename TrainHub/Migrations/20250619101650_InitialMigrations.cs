using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainHub.Migrations
{
    /// <inheritdoc />
<<<<<<<< HEAD:TrainHub/Migrations/20250619101650_InitialMigrations.cs
    public partial class InitialMigrations : Migration
========
    public partial class InitialCreate : Migration
>>>>>>>> feature-dashboard-backend:TrainHub/Migrations/20250619173821_InitialCreate.cs
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
<<<<<<<< HEAD:TrainHub/Migrations/20250619101650_InitialMigrations.cs
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageCapturedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
========
                    DaysToExpiry = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true)
>>>>>>>> feature-dashboard-backend:TrainHub/Migrations/20250619173821_InitialCreate.cs
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAdmin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
<<<<<<<< HEAD:TrainHub/Migrations/20250619101650_InitialMigrations.cs

            migrationBuilder.CreateTable(
                name: "MemberAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    CheckOutTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberAttendances_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberAttendances_MemberId",
                table: "MemberAttendances",
                column: "MemberId");
========
>>>>>>>> feature-dashboard-backend:TrainHub/Migrations/20250619173821_InitialCreate.cs
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberAttendances");

            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.DropTable(
<<<<<<<< HEAD:TrainHub/Migrations/20250619101650_InitialMigrations.cs
                name: "User");

            migrationBuilder.DropTable(
                name: "Member");
========
                name: "Trainer");

            migrationBuilder.DropTable(
                name: "User");
>>>>>>>> feature-dashboard-backend:TrainHub/Migrations/20250619173821_InitialCreate.cs
        }
    }
}
