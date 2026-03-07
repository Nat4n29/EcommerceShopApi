using EcommerceAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
    public decimal TotalValue { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal SupplierValue { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal ShippingValue { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal NetValue => TotalValue - SupplierValue - ShippingValue;
    public StatusEnum Status { get; set; }

    //

    public int MonthResumeId { get; set; }
    [JsonIgnore]
    public MonthResume? OrderMonthResume { get; set; }
}
