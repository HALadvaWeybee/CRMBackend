using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRMBackend.Migrations
{
    public partial class Contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Countries_CountriesId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_City_States_StatesId",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_City_StatesId",
                table: "Cities",
                newName: "IX_Cities_StatesId");

            migrationBuilder.RenameIndex(
                name: "IX_City_CountriesId",
                table: "Cities",
                newName: "IX_Cities_CountriesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhoneNo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhoneNo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportantDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImportantDateDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonBirthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonPinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonPhoneNo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonPhoneNo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Person2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Person2Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Person2Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Person2Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationORIndividualId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_OrganizationORIndividual_OrganizationORIndividualId",
                        column: x => x.OrganizationORIndividualId,
                        principalTable: "OrganizationORIndividual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDocument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDocument_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserNote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNote_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPhoto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPhoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPhoto_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_OrganizationORIndividualId",
                table: "Contacts",
                column: "OrganizationORIndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDocument_ContactsId",
                table: "UserDocument",
                column: "ContactsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNote_ContactsId",
                table: "UserNote",
                column: "ContactsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPhoto_ContactsId",
                table: "UserPhoto",
                column: "ContactsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountriesId",
                table: "Cities",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_States_StatesId",
                table: "Cities",
                column: "StatesId",
                principalTable: "States",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountriesId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_States_StatesId",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "UserDocument");

            migrationBuilder.DropTable(
                name: "UserNote");

            migrationBuilder.DropTable(
                name: "UserPhoto");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_StatesId",
                table: "City",
                newName: "IX_City_StatesId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountriesId",
                table: "City",
                newName: "IX_City_CountriesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Countries_CountriesId",
                table: "City",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_City_States_StatesId",
                table: "City",
                column: "StatesId",
                principalTable: "States",
                principalColumn: "Id");
        }
    }
}
