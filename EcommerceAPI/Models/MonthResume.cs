using System.Collections.ObjectModel;

namespace EcommerceAPI.Models;

public class MonthResume
{
    public MonthResume()
    {
        MonthOrders = new Collection<Order>();
        MonthDaysResume = new Collection<DayResume>();
    }

    public int MonthResumeId { get; set; }
    public DateTime Month { get; set; }
    public ICollection<Order>? MonthOrders { get; set; }
    public ICollection<DayResume>? MonthDaysResume { get; set; }
}
