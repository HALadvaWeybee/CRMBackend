using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMBackend.Migrations
{
    public partial class ManageGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManageGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationORIndividualId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManageGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManageGroup_OrganizationORIndividual_OrganizationORIndividualId",
                        column: x => x.OrganizationORIndividualId,
                        principalTable: "OrganizationORIndividual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManageCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManageCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManageCategory_ManageGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "ManageGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManageSubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManageSubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManageSubCategory_ManageCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ManageCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManageCategory_GroupId",
                table: "ManageCategory",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ManageGroup_OrganizationORIndividualId",
                table: "ManageGroup",
                column: "OrganizationORIndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_ManageSubCategory_CategoryId",
                table: "ManageSubCategory",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManageSubCategory");

            migrationBuilder.DropTable(
                name: "ManageCategory");

            migrationBuilder.DropTable(
                name: "ManageGroup");
        }
    }
}
