﻿using System;
using System.Collections.Generic;

namespace _01._db_first_model_demo.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string AddressText { get; set; } = null!;

    public int? TownId { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Town? Town { get; set; }
}
