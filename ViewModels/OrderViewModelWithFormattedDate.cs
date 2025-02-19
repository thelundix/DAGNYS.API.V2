using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dagnys.api.ViewModels;

public class OrderViewModelWithFormattedDate
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public int CustomerId { get; set; }
    public string OrderDate { get; set; } // Formaterad sträng
    public List<OrderItemViewModel> OrderItems { get; set; }
}
