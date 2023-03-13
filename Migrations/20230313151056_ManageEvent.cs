using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMBackend.Migrations
{
    public partial class ManageEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManageEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactCount = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrganizationORIndividualId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManageEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManageEvent_OrganizationORIndividual_OrganizationORIndividualId",
                        column: x => x.OrganizationORIndividualId,
                        principalTable: "OrganizationORIndividual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManageEvent_OrganizationORIndividualId",
                table: "ManageEvent",
                column: "OrganizationORIndividualId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManageEvent");
        }
    }
}
