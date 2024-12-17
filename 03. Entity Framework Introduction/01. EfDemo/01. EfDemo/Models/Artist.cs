using System;
using System.Collections.Generic;

namespace _01._EfDemo.Models;

public partial class Artist
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ArtistMetadatum> ArtistMetadata { get; set; } = new List<ArtistMetadatum>();

    public virtual ICollection<SongArtist> SongArtists { get; set; } = new List<SongArtist>();
}
