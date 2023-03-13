using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMBackend.Migrations
{
    public partial class UserTabler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationORIndividualId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEmails_OrganizationORIndividual_OrganizationORIndividualId",
                        column: x => x.OrganizationORIndividualId,
                        principalTable: "OrganizationORIndividual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSMSs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationORIndividualId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSMSs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSMSs_OrganizationORIndividual_OrganizationORIndividualId",
                        column: x => x.OrganizationORIndividualId,
                        principalTable: "OrganizationORIndividual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipientsEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipientsEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipientsEmails_UserEmails_UserEmailId",
                        column: x => x.UserEmailId,
                        principalTable: "UserEmails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipientsPhoneNos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSMSId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipientsPhoneNos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipientsPhoneNos_UserSMSs_UserSMSId",
                        column: x => x.UserSMSId,
                        principalTable: "UserSMSs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipientsEmails_UserEmailId",
                table: "RecipientsEmails",
                column: "UserEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipientsPhoneNos_UserSMSId",
                table: "RecipientsPhoneNos",
                column: "UserSMSId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmails_OrganizationORIndividualId",
                table: "UserEmails",
                column: "OrganizationORIndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSMSs_OrganizationORIndividualId",
                table: "UserSMSs",
                column: "OrganizationORIndividualId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipientsEmails");

            migrationBuilder.DropTable(
                name: "RecipientsPhoneNos");

            migrationBuilder.DropTable(
                name: "UserEmails");

            migrationBuilder.DropTable(
                name: "UserSMSs");
        }
    }
}
