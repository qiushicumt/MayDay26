using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _04Mvc4MusicStore.Models
{
    
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }

    public class Album
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string AlbumTitle { get; set; }
        public decimal AlbumPrice { get; set; }
        public string AlbumArtUrl { get; set; }
        public Genre AlbumGenre { get; set; }
        public Artist Artist { get; set; }
    }

    public class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
    }
}