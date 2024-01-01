using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class migdeneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PoliId",
                table: "Doktors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PoliklinikPoliId",
                table: "Doktors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doktors_PoliklinikPoliId",
                table: "Doktors",
                column: "PoliklinikPoliId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doktors_Polikliniks_PoliklinikPoliId",
                table: "Doktors",
                column: "PoliklinikPoliId",
                principalTable: "Polikliniks",
                principalColumn: "PoliId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doktors_Polikliniks_PoliklinikPoliId",
                table: "Doktors");

            migrationBuilder.DropIndex(
                name: "IX_Doktors_PoliklinikPoliId",
                table: "Doktors");

            migrationBuilder.DropColumn(
                name: "PoliId",
                table: "Doktors");

            migrationBuilder.DropColumn(
                name: "PoliklinikPoliId",
                table: "Doktors");
        }
    }
}
