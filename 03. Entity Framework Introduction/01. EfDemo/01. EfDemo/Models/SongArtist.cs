﻿using System;
using System.Collections.Generic;

namespace _01._EfDemo.Models;

public partial class SongArtist
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedOn { get; set; }

    public int SongId { get; set; }

    public int ArtistId { get; set; }

    public int Order { get; set; }

    public virtual Artist Artist { get; set; } = null!;

    public virtual Song Song { get; set; } = null!;
}
