using System;
using System.Collections.Generic;
namespace TravelAgency.Models;


public partial class TourPackage
{
    public int IdTourPackage { get; set; }

    public int NumberTypeRoom { get; set; }

    public int NumberTypeFood { get; set; }

    public int NumberTypeTransport { get; set; }

    public int NumberHotel { get; set; }

    public string Description { get; set; } = null!;

    public DateTime DateStart { get; set; }

    public int PopularityRate { get; set; }

    public int NumberCertification { get; set; }

   
}
