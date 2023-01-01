using System;
using System.Collections.Generic;

namespace TravelAgency.Models;


public partial class Hotel
{
    public int IdHotel { get; set; }

    public string NameHotel { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public int NumberCountry { get; set; }

    public int Stars { get; set; }


}
