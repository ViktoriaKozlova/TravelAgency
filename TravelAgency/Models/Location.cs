using System;
using System.Collections.Generic;

namespace TravelAgency.Models;


public partial class Location
{
    public int IdLocation { get; set; }

    public string Place { get; set; } = null!;

    public int NumberCountry { get; set; }


}
