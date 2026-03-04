using EcommerceAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Models;

[Table("Order")]
public class Order
{
    [Key]
    public int OrderId { get; set; }
    public DateTime Date { get; set; }
    public int ShopifyId { get; set; }
    public int DropiId { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal SupplierValue { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal ShippingValue { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal TotalValue { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal NetValue { get; set; }
    public StatusEnum Status { get; set; }

    public MonthResume? OrderMonthResume { get; set; }
}
