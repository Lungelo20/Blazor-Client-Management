using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RTT.Server.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "clientContacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "clientContacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "clientContacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "clientContacts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "clientContacts");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "clientAddresses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "clientContacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "clientAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "clientAddresses",
                columns: new[] { "Id", "AddressType", "City", "ClientDetailsId", "ClientId", "Code", "Country", "LineOne", "LineTwo", "Province", "Status" },
                values: new object[,]
                {
                    { 1, "Work", "Test City", null, 1, "1234", "South Africa", "80 Testing Road", "Surburb Tested", "Gauteng", 0 },
                    { 2, "Residential", "City Q", null, 1, "666", "South Africa", "98 Testing Road", "Surburb Tested", "KZN", 0 },
                    { 3, "Work", "Test City", null, 2, "0000", "South Africa", "2 Testing Road", "Surburb Tested", "Limpompo", 0 },
                    { 4, "Work", "Test City", null, 3, "1234", "South Africa", "80 Testing Road", "Surburb Tested", "Gauteng", 0 }
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
        }
    }
}
