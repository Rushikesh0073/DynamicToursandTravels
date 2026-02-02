using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToursAndTravelsManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabBookingId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UTR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_CabBookings_CabBookingId",
                        column: x => x.CabBookingId,
                        principalTable: "CabBookings",
                        principalColumn: "CabBookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpiId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpiName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSettings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cabs",
                keyColumn: "CabId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 31, 20, 11, 53, 482, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Cabs",
                keyColumn: "CabId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 31, 20, 11, 53, 482, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 31, 20, 11, 53, 482, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 31, 20, 11, 53, 482, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 31, 20, 11, 53, 482, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 31, 20, 11, 53, 482, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CabBookingId",
                table: "Payments",
                column: "CabBookingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentSettings");

            migrationBuilder.UpdateData(
                table: "Cabs",
                keyColumn: "CabId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 29, 21, 22, 38, 808, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Cabs",
                keyColumn: "CabId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 29, 21, 22, 38, 808, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 29, 21, 22, 38, 808, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 29, 21, 22, 38, 808, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 29, 21, 22, 38, 808, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 29, 21, 22, 38, 808, DateTimeKind.Local).AddTicks(311));
        }
    }
}
