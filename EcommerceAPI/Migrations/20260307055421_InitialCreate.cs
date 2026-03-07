using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Month_Resume",
                columns: table => new
                {
                    MonthResumeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Month_Resume", x => x.MonthResumeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Day_Resume",
                columns: table => new
                {
                    DayResumeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Delivered = table.Column<int>(type: "int", nullable: false),
                    Return = table.Column<int>(type: "int", nullable: false),
                    GrossRenevue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Expense = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    FacebookExpense = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DollarNetValue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    RealNetValue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DollarWithdrawal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    RealWithdrawal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    WithdrawalExpense = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CardValue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MonthResumeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day_Resume", x => x.DayResumeId);
                    table.ForeignKey(
                        name: "FK_Day_Resume_Month_Resume_MonthResumeId",
                        column: x => x.MonthResumeId,
                        principalTable: "Month_Resume",
                        principalColumn: "MonthResumeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ShopifyId = table.Column<int>(type: "int", nullable: false),
                    DropiId = table.Column<int>(type: "int", nullable: false),
                    TotalValue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    SupplierValue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ShippingValue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MonthResumeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Month_Resume_MonthResumeId",
                        column: x => x.MonthResumeId,
                        principalTable: "Month_Resume",
                        principalColumn: "MonthResumeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Day_Resume_MonthResumeId",
                table: "Day_Resume",
                column: "MonthResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_MonthResumeId",
                table: "Order",
                column: "MonthResumeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Day_Resume");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Month_Resume");
        }
    }
}
