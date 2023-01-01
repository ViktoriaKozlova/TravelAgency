using System;
using System.Collections.Generic;

namespace TravelAgency.Models;


public partial class Insurance
{
    public int IdInsurance { get; set; }

    public string NameInsurance { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int NumberInsuranceCompany { get; set; }

    public int Price { get; set; }

    public DateTime DateLicense { get; set; }

}
