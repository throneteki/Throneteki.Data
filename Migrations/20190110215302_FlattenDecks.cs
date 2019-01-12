namespace CrimsonDev.Throneteki.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class FlattenDecks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deck_Card_AgendaId",
                table: "Deck");

            migrationBuilder.DropIndex(
                name: "IX_Deck_AgendaId",
                table: "Deck");

            migrationBuilder.DropColumn(
                name: "AgendaId",
                table: "Deck");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgendaId",
                table: "Deck",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deck_AgendaId",
                table: "Deck",
                column: "AgendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deck_Card_AgendaId",
                table: "Deck",
                column: "AgendaId",
                principalTable: "Card",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
