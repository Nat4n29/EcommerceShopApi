using EcommerceAPI.Enums;

namespace EcommerceAPI.Models;

public class Order
{
    public int OrderId { get; set; }
    public DateTime Date { get; set; }
    public int ShopifyId { get; set; }
    public int DropiId { get; set; }
    public float SupplierValue { get; set; }
    public float ShippingValue { get; set; }
    public float TotalValue { get; set; }
    public float NetValue { get; set; }
    public StatusEnum Status { get; set; }

    public MonthResume? OrderMonthResume { get; set; }
}
