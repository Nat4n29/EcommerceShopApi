using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text.Json.Serialization;

namespace EcommerceAPI.Models;

[Table("Day_Resume")]
public class DayResume
{
    [Key]
    public int DayResumeId { get; set; }
    [Range(1,31)]
    public int Day { get; set; }
    public int Delivered { get; set; }
    public int Return { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal GrossRenevue { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal Expense { get; set; }
    public decimal FacebookExpense { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal DollarNetValue { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal RealNetValue { get; set; }

    //

    [Column(TypeName = "decimal(10,2)")]
    public decimal DollarWithdrawal { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal RealWithdrawal { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public decimal WithdrawalExpense { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal CardValue { get; set; }
    
    //

    public int MonthResumeId { get; set; }
    [JsonIgnore]
    public MonthResume? DayMonthResume { get; set; }
}
