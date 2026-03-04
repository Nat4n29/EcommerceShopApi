using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddOrdersTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO `Order` (`Date`, ShopifyId, DropiId, SupplierValue, ShippingValue, TotalValue, NetValue, Status) " +
                   "VALUES (NOW(), 123, 567, 5.55, 2.00, 0.00, 0.00, 0);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Order");
        }
    }
}
