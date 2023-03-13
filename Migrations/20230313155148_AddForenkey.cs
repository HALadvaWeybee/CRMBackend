using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMBackend.Migrations
{
    public partial class AddForenkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactEvent",
                columns: table => new
                {
                    ContactsId = table.Column<int>(type: "int", nullable: false),
                    ManageEventsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEvent", x => new { x.ContactsId, x.ManageEventsId });
                    table.ForeignKey(
                        name: "FK_ContactEvent_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContactEvent_ManageEvent_ManageEventsId",
                        column: x => x.ManageEventsId,
                        principalTable: "ManageEvent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactEvent_ManageEventsId",
                table: "ContactEvent",
                column: "ManageEventsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactEvent");
        }
    }
}
