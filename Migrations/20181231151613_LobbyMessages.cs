namespace CrimsonDev.Throneteki.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;
    using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

    public partial class LobbyMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestrictedListJoustCard_RestrictedListEntry_RestrictedListE~",
                table: "RestrictedListJoustCard");

            migrationBuilder.DropForeignKey(
                name: "FK_RestrictedListMeleeCard_RestrictedListEntry_RestrictedListE~",
                table: "RestrictedListMeleeCard");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Pack_Code",
                table: "Pack");

            migrationBuilder.DropIndex(
                name: "IX_Faction_Code",
                table: "Faction");

            migrationBuilder.DropIndex(
                name: "IX_Card_Code",
                table: "Card");

            migrationBuilder.CreateTable(
                name: "LobbyMessage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MessageText = table.Column<string>(nullable: true),
                    SenderId = table.Column<string>(nullable: true),
                    MessageDateTime = table.Column<DateTime>(nullable: false),
                    Removed = table.Column<bool>(nullable: false),
                    RemovedById = table.Column<string>(nullable: true),
                    RemovedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LobbyMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LobbyMessage_Users_RemovedById",
                        column: x => x.RemovedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LobbyMessage_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pack_Code",
                table: "Pack",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Faction_Code",
                table: "Faction",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Card_Code",
                table: "Card",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LobbyMessage_RemovedById",
                table: "LobbyMessage",
                column: "RemovedById");

            migrationBuilder.CreateIndex(
                name: "IX_LobbyMessage_SenderId",
                table: "LobbyMessage",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestrictedListJoustCard_RestrictedListEntry_RestrictedListEntryId",
                table: "RestrictedListJoustCard",
                column: "RestrictedListEntryId",
                principalTable: "RestrictedListEntry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestrictedListMeleeCard_RestrictedListEntry_RestrictedListEntryId",
                table: "RestrictedListMeleeCard",
                column: "RestrictedListEntryId",
                principalTable: "RestrictedListEntry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestrictedListJoustCard_RestrictedListEntry_RestrictedListEntryId",
                table: "RestrictedListJoustCard");

            migrationBuilder.DropForeignKey(
                name: "FK_RestrictedListMeleeCard_RestrictedListEntry_RestrictedListEntryId",
                table: "RestrictedListMeleeCard");

            migrationBuilder.DropTable(
                name: "LobbyMessage");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Pack_Code",
                table: "Pack");

            migrationBuilder.DropIndex(
                name: "IX_Faction_Code",
                table: "Faction");

            migrationBuilder.DropIndex(
                name: "IX_Card_Code",
                table: "Card");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pack_Code",
                table: "Pack",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Faction_Code",
                table: "Faction",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Card_Code",
                table: "Card",
                column: "Code",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RestrictedListJoustCard_RestrictedListEntry_RestrictedListE~",
                table: "RestrictedListJoustCard",
                column: "RestrictedListEntryId",
                principalTable: "RestrictedListEntry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestrictedListMeleeCard_RestrictedListEntry_RestrictedListE~",
                table: "RestrictedListMeleeCard",
                column: "RestrictedListEntryId",
                principalTable: "RestrictedListEntry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
