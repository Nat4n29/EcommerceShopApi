using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Models;

[Table("Month Resume")]
public class MonthResume
{
    public MonthResume()
    {
        MonthOrders = new Collection<Order>();
        MonthDaysResume = new Collection<DayResume>();
    }

    [Key]
    public int MonthResumeId { get; set; }
    public DateTime Month { get; set; }
    public ICollection<Order>? MonthOrders { get; set; }
    public ICollection<DayResume>? MonthDaysResume { get; set; }
}
