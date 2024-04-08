using System;
using System.Collections.Generic;

namespace Assignment4_Dariya_N01633069.Models.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public DateTime? DateCreated { get; set; }
}
