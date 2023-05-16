using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "Rezervations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_DestinationId",
                table: "Rezervations",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervations_Destinations_DestinationId",
                table: "Rezervations",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervations_Destinations_DestinationId",
                table: "Rezervations");

            migrationBuilder.DropIndex(
                name: "IX_Rezervations_DestinationId",
                table: "Rezervations");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Rezervations");
        }
    }
}
