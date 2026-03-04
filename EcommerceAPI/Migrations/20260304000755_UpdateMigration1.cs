using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DaysResume_MonthsResume_DayMonthResumeMonthResumeId",
                table: "DaysResume");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_MonthsResume_OrderMonthResumeMonthResumeId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthsResume",
                table: "MonthsResume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DaysResume",
                table: "DaysResume");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "MonthsResume",
                newName: "Month Resume");

            migrationBuilder.RenameTable(
                name: "DaysResume",
                newName: "Day Resume");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_OrderMonthResumeMonthResumeId",
                table: "Order",
                newName: "IX_Order_OrderMonthResumeMonthResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_DaysResume_DayMonthResumeMonthResumeId",
                table: "Day Resume",
                newName: "IX_Day Resume_DayMonthResumeMonthResumeId");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalValue",
                table: "Order",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "SupplierValue",
                table: "Order",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "ShippingValue",
                table: "Order",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetValue",
                table: "Order",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "WithdrawalExpense",
                table: "Day Resume",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "RealWithdrawal",
                table: "Day Resume",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "RealNetValue",
                table: "Day Resume",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossRenevue",
                table: "Day Resume",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "FacebookExpense",
                table: "Day Resume",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Expense",
                table: "Day Resume",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "DollarWithdrawal",
                table: "Day Resume",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "DollarNetValue",
                table: "Day Resume",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "CardValue",
                table: "Day Resume",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Month Resume",
                table: "Month Resume",
                column: "MonthResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Day Resume",
                table: "Day Resume",
                column: "DayResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Day Resume_Month Resume_DayMonthResumeMonthResumeId",
                table: "Day Resume",
                column: "DayMonthResumeMonthResumeId",
                principalTable: "Month Resume",
                principalColumn: "MonthResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Month Resume_OrderMonthResumeMonthResumeId",
                table: "Order",
                column: "OrderMonthResumeMonthResumeId",
                principalTable: "Month Resume",
                principalColumn: "MonthResumeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Day Resume_Month Resume_DayMonthResumeMonthResumeId",
                table: "Day Resume");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Month Resume_OrderMonthResumeMonthResumeId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Month Resume",
                table: "Month Resume");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Day Resume",
                table: "Day Resume");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Month Resume",
                newName: "MonthsResume");

            migrationBuilder.RenameTable(
                name: "Day Resume",
                newName: "DaysResume");

            migrationBuilder.RenameIndex(
                name: "IX_Order_OrderMonthResumeMonthResumeId",
                table: "Orders",
                newName: "IX_Orders_OrderMonthResumeMonthResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_Day Resume_DayMonthResumeMonthResumeId",
                table: "DaysResume",
                newName: "IX_DaysResume_DayMonthResumeMonthResumeId");

            migrationBuilder.AlterColumn<float>(
                name: "TotalValue",
                table: "Orders",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "SupplierValue",
                table: "Orders",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "ShippingValue",
                table: "Orders",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "NetValue",
                table: "Orders",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "WithdrawalExpense",
                table: "DaysResume",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "RealWithdrawal",
                table: "DaysResume",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "RealNetValue",
                table: "DaysResume",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "GrossRenevue",
                table: "DaysResume",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "FacebookExpense",
                table: "DaysResume",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<float>(
                name: "Expense",
                table: "DaysResume",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "DollarWithdrawal",
                table: "DaysResume",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "DollarNetValue",
                table: "DaysResume",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<float>(
                name: "CardValue",
                table: "DaysResume",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthsResume",
                table: "MonthsResume",
                column: "MonthResumeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DaysResume",
                table: "DaysResume",
                column: "DayResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DaysResume_MonthsResume_DayMonthResumeMonthResumeId",
                table: "DaysResume",
                column: "DayMonthResumeMonthResumeId",
                principalTable: "MonthsResume",
                principalColumn: "MonthResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_MonthsResume_OrderMonthResumeMonthResumeId",
                table: "Orders",
                column: "OrderMonthResumeMonthResumeId",
                principalTable: "MonthsResume",
                principalColumn: "MonthResumeId");
        }
    }
}
