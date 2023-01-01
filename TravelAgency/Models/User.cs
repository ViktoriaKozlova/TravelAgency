using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace TravelAgency.Models;

public partial class User
{
    public int IdUser { get; set; }

    public int NumberRole { get; set; }

    public string Fullname { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Number { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string PassportNumber { get; set; }



}