using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainHub.Migrations
{
    /// <inheritdoc />
    public partial class removeTrainerIDTemporarily : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainerID",
                table: "Member",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
