using System.Security.Principal;

namespace EcommerceAPI.Models;

public class DayResume
{
    public int DayResumeId { get; set; }
    public DateTime Day { get; set; }
    public int Delivered { get; set; }
    public int Return { get; set; }
    public float GrossRenevue { get; set; }
    public float Expense { get; set; }
    public float FacebookExpense { get; set; }
    public float DollarNetValue { get; set; }
    public float RealNetValue { get; set; }

    public float DollarWithdrawal { get; set; }
    public float RealWithdrawal { get; set; }
    public float WithdrawalExpense { get; set; }

    public float CardValue { get; set; }

    public MonthResume? DayMonthResume { get; set; }
}
