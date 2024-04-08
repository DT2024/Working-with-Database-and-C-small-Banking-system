using System;
using System.Collections.Generic;

namespace Assignment4_Dariya_N01633069.Models.Entities;

public partial class Account
{
    public int AccountId { get; set; }

    public string AccountType { get; set; }

    public int UserId { get; set; }

    public double? CurrentBalance { get; set; }

    public DateTime? DateCreated { get; set; }
}
