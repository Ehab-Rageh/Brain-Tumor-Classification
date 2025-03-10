using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Brain_Tumor_Classification.Migrations
{
    /// <inheritdoc />
    public partial class solveuseridissue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_AspNetUsers_UserId",
                table: "MedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_UserId",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MedicalRecords");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "MedicalRecords",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_ApplicationUserId",
                table: "MedicalRecords",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_AspNetUsers_ApplicationUserId",
                table: "MedicalRecords",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_AspNetUsers_ApplicationUserId",
                table: "MedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_ApplicationUserId",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "MedicalRecords");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MedicalRecords",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_UserId",
                table: "MedicalRecords",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_AspNetUsers_UserId",
                table: "MedicalRecords",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
