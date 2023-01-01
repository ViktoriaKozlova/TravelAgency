using System;
using System.Collections.Generic;

namespace TravelAgency.Models;


public partial class Tour
{
    public int IdTour { get; set; }

    public DateTime DepartureDate { get; set; }

    public DateTime ArrivalDate { get; set; }

    public int AmountSeats { get; set; }

    public int NumberTypeTour { get; set; }

    public int Price { get; set; }

    public string Description { get; set; } = null!;

    public int NumberLocation { get; set; }

    public string Remark { get; set; } = null!;

    public int NumberTourOperator { get; set; }

    public int number_status { get; set; }
}
