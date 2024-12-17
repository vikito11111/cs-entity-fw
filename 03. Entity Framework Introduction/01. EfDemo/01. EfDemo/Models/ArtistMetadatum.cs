﻿using System;
using System.Collections.Generic;

namespace _01._EfDemo.Models;

public partial class ArtistMetadatum
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedOn { get; set; }

    public int ArtistId { get; set; }

    public int Type { get; set; }

    public string? Value { get; set; }

    public int? SourceId { get; set; }

    public string? SourceItemId { get; set; }

    public virtual Artist Artist { get; set; } = null!;

    public virtual Source? Source { get; set; }
}
