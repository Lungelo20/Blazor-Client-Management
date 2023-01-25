using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RTT.Server.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "ClientId", "Code", "Country", "LineOne", "LineTwo", "Province" },
                values: new object[] { "Test City", 1, "1234", "South Africa", "80 Testing Road", "Surburb Tested", "Gauteng" });

            migrationBuilder.UpdateData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "ClientId", "Code", "Country", "LineOne", "LineTwo", "Province" },
                values: new object[] { "City Q", 1, "666", "South Africa", "98 Testing Road", "Surburb Tested", "KZN" });

            migrationBuilder.UpdateData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressType", "City", "ClientId", "Code", "Country", "LineOne", "LineTwo", "Province" },
                values: new object[] { "Work", "Test City", 2, "0000", "South Africa", "2 Testing Road", "Surburb Tested", "Limpompo" });

            migrationBuilder.UpdateData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressType", "City", "ClientId", "Code", "Country", "LineOne", "LineTwo", "Province" },
                values: new object[] { "Work", "Test City", 3, "1234", "South Africa", "80 Testing Road", "Surburb Tested", "Gauteng" });

            migrationBuilder.InsertData(
                table: "clientDetails",
                columns: new[] { "Id", "Gender", "Name", "Status" },
                values: new object[,]
                {
                    { 3, "M", "C Client", 1 },
                    { 4, "F", "D Client", 0 },
                    { 5, "M", "E Client", 1 },
                    { 6, "F", "F Client", 0 },
                    { 7, "M", "G Client", 1 },
                    { 8, "F", "H Client", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "clientDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "clientDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "clientDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "clientDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "clientDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "ClientId", "Code", "Country", "LineOne", "LineTwo", "Province" },
                values: new object[] { "", 0, "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "ClientId", "Code", "Country", "LineOne", "LineTwo", "Province" },
                values: new object[] { "", 0, "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressType", "City", "ClientId", "Code", "Country", "LineOne", "LineTwo", "Province" },
                values: new object[] { "Physical", "", 0, "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "clientAddresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressType", "City", "ClientId", "Code", "Country", "LineOne", "LineTwo", "Province" },
                values: new object[] { "Postal", "", 0, "", "", "", "", "" });
        }
    }
}
