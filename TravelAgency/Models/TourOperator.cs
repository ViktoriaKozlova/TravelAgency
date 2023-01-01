using System;
using System.Collections.Generic;

namespace TravelAgency.Models;

public partial class TourOperator
{
    public int IdTourOperator { get; set; }

    public string NameTourOperator { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int NumberRegistration { get; set; }

    public DateTime DateOfContract { get; set; }

    public int NumberPhone { get; set; }


}
