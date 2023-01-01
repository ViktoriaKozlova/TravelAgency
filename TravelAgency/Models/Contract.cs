using System;
using System.Collections.Generic;

namespace TravelAgency.Models;

public partial class Contract
{
    public int IdContract { get; set; }

    public int NumberUser { get; set; }

    public DateTime DateOfConclusion { get; set; }

    public int NumberStatus { get; set; }

    public int QuantityTourists { get; set; }

    public int NumberInvoice { get; set; }

    public int CostDopUslugi { get; set; }

    public string Description { get; set; } = null!;

    public int NumberInsurance { get; set; }

    public int NumberTour { get; set; }


}
