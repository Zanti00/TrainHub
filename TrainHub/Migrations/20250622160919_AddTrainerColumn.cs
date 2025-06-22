using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainHub.Migrations
{
    /// <inheritdoc />
    public partial class AddTrainerColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainerID",
                table: "Member",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_TrainerID",
                table: "Member",
                column: "TrainerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Trainer_TrainerID",
                table: "Member",
                column: "TrainerID",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_Trainer_TrainerID",
                table: "Member");

            migrationBuilder.DropIndex(
                name: "IX_Member_TrainerID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "TrainerID",
                table: "Member");
        }
    }
}
