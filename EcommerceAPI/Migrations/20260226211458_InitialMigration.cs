using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MonthsResume",
                columns: table => new
                {
                    MonthResumeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Month = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthsResume", x => x.MonthResumeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DaysResume",
                columns: table => new
                {
                    DayResumeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Day = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Delivered = table.Column<int>(type: "int", nullable: false),
                    Return = table.Column<int>(type: "int", nullable: false),
                    GrossRenevue = table.Column<float>(type: "float", nullable: false),
                    Expense = table.Column<float>(type: "float", nullable: false),
                    FacebookExpense = table.Column<float>(type: "float", nullable: false),
                    DollarNetValue = table.Column<float>(type: "float", nullable: false),
                    RealNetValue = table.Column<float>(type: "float", nullable: false),
                    DollarWithdrawal = table.Column<float>(type: "float", nullable: false),
                    RealWithdrawal = table.Column<float>(type: "float", nullable: false),
                    WithdrawalExpense = table.Column<float>(type: "float", nullable: false),
                    CardValue = table.Column<float>(type: "float", nullable: false),
                    DayMonthResumeMonthResumeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysResume", x => x.DayResumeId);
                    table.ForeignKey(
                        name: "FK_DaysResume_MonthsResume_DayMonthResumeMonthResumeId",
                        column: x => x.DayMonthResumeMonthResumeId,
                        principalTable: "MonthsResume",
                        principalColumn: "MonthResumeId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ShopifyId = table.Column<int>(type: "int", nullable: false),
                    DropiId = table.Column<int>(type: "int", nullable: false),
                    SupplierValue = table.Column<float>(type: "float", nullable: false),
                    ShippingValue = table.Column<float>(type: "float", nullable: false),
                    TotalValue = table.Column<float>(type: "float", nullable: false),
                    NetValue = table.Column<float>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OrderMonthResumeMonthResumeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_MonthsResume_OrderMonthResumeMonthResumeId",
                        column: x => x.OrderMonthResumeMonthResumeId,
                        principalTable: "MonthsResume",
                        principalColumn: "MonthResumeId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DaysResume_DayMonthResumeMonthResumeId",
                table: "DaysResume",
                column: "DayMonthResumeMonthResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderMonthResumeMonthResumeId",
                table: "Orders",
                column: "OrderMonthResumeMonthResumeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaysResume");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "MonthsResume");
        }
    }
}
