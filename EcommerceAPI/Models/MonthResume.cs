using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Models;

[Table("Month_Resume")]
public class MonthResume
{
    public MonthResume()
    {
        MonthOrders = new Collection<Order>();
        MonthDaysResume = new Collection<DayResume>();
    }

    [Key]
    public int MonthResumeId { get; set; }
    [Range(1,12)]
    public int Month { get; set; }
    public int Year { get; set; }
    public ICollection<Order>? MonthOrders { get; set; }
    public ICollection<DayResume>? MonthDaysResume { get; set; }
}
