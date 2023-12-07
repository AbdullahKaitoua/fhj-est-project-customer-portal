using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fhj_est_customer_portal.Migrations
{
    /// <inheritdoc />
    public partial class AddChargingStationEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChargingStations",
                columns: table => new
                {
                    uuid = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SerialNbr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FirmwareVersion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OperatorName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Long = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BillingBegin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BillingEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnergyProvider = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChargingStations", x => x.uuid);
                    table.ForeignKey(
                        name: "FK_ChargingStations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChargingStations_UserId",
                table: "ChargingStations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChargingStations");
        }
    }
}
