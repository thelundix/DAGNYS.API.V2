using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dagnys.api.ViewModels;

public class CustomerViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string ContactPerson { get; set; }
    public string DeliveryAddress { get; set; }
    public string InvoiceAddress { get; set; }
}
