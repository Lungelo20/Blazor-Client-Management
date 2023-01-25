using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RTT.Server.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientAddresses_clientDetails_ClientDetailsId",
                table: "clientAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_clientContacts_clientDetails_ClientDetailsId",
                table: "clientContacts");

            migrationBuilder.AlterColumn<int>(
                name: "ClientDetailsId",
                table: "clientContacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientDetailsId",
                table: "clientAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_clientAddresses_clientDetails_ClientDetailsId",
                table: "clientAddresses",
                column: "ClientDetailsId",
                principalTable: "clientDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clientContacts_clientDetails_ClientDetailsId",
                table: "clientContacts",
                column: "ClientDetailsId",
                principalTable: "clientDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientAddresses_clientDetails_ClientDetailsId",
                table: "clientAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_clientContacts_clientDetails_ClientDetailsId",
                table: "clientContacts");

            migrationBuilder.AlterColumn<int>(
                name: "ClientDetailsId",
                table: "clientContacts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientDetailsId",
                table: "clientAddresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_clientAddresses_clientDetails_ClientDetailsId",
                table: "clientAddresses",
                column: "ClientDetailsId",
                principalTable: "clientDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientContacts_clientDetails_ClientDetailsId",
                table: "clientContacts",
                column: "ClientDetailsId",
                principalTable: "clientDetails",
                principalColumn: "Id");
        }
    }
}
