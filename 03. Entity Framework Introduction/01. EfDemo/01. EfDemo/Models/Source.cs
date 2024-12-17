using System;
using System.Collections.Generic;

namespace _01._EfDemo.Models;

public partial class Source
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ArtistMetadatum> ArtistMetadata { get; set; } = new List<ArtistMetadatum>();

    public virtual ICollection<SongMetadatum> SongMetadata { get; set; } = new List<SongMetadatum>();

    public virtual ICollection<Song> Songs { get; set; } = new List<Song>();
}
