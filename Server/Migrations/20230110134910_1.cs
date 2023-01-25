using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RTT.Server.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clientAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LineOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LineTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ClientDetailsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clientAddresses_clientDetails_ClientDetailsId",
                        column: x => x.ClientDetailsId,
                        principalTable: "clientDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "clientContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ClientDetailsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clientContacts_clientDetails_ClientDetailsId",
                        column: x => x.ClientDetailsId,
                        principalTable: "clientDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "clientAddresses",
                columns: new[] { "Id", "AddressType", "City", "ClientDetailsId", "ClientId", "Code", "Country", "LineOne", "LineTwo", "Province", "Status" },
                values: new object[,]
                {
                    { 1, "Work", "", null, 0, "", "", "", "", "", 0 },
                    { 2, "Residential", "", null, 0, "", "", "", "", "", 0 },
                    { 3, "Physical", "", null, 0, "", "", "", "", "", 0 },
                    { 4, "Postal", "", null, 0, "", "", "", "", "", 0 }
                });

            migrationBuilder.InsertData(
                table: "clientContacts",
                columns: new[] { "Id", "ClientDetailsId", "ClientId", "Contact", "ContactType", "Status" },
                values: new object[,]
                {
                    { 1, null, 0, "", "Work Number", 0 },
                    { 2, null, 0, "", "Cell Number", 0 },
                    { 3, null, 0, "", "Email", 0 },
                    { 4, null, 0, "", "Other", 0 }
                });

            migrationBuilder.InsertData(
                table: "clientDetails",
                columns: new[] { "Id", "Gender", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "M", "A Client", 1 },
                    { 2, "F", "B Client", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientAddresses_ClientDetailsId",
                table: "clientAddresses",
                column: "ClientDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_clientContacts_ClientDetailsId",
                table: "clientContacts",
                column: "ClientDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientAddresses");

            migrationBuilder.DropTable(
                name: "clientContacts");

            migrationBuilder.DropTable(
                name: "clientDetails");
        }
    }
}
