using _01._EfDemo.Models;
using Microsoft.EntityFrameworkCore;

var optionBuilder = new DbContextOptionsBuilder<MusicXContext>();
optionBuilder.UseSqlServer("Server=.;Database=Softuni;Integrated Security=true;TrustServerCertificate=True");

var db = new MusicXContext(optionBuilder.Options);

db.Database.EnsureCreated();

var firstArtist = db.Artists.FirstOrDefault();
Console.WriteLine($"{firstArtist?.Name} with id: {firstArtist?.Id} was created on {firstArtist?.CreatedOn}");

var songsCount = db.Songs.Count();

Console.WriteLine(songsCount);

var artists = db.Artists.Select(x => new
{
    x.Name,
    Count = x.SongArtists.Count(),
}).OrderByDescending(x => x.Count).Take(100).ToList();

foreach (var artist in artists)
{
    Console.WriteLine($"{artist.Name} => {artist.Count}");
}