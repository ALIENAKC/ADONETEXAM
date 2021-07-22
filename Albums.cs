using System;
using System.Collections.Generic;
using System.Text;

namespace ADONETEXAM.Models
{
    public class Albums
    {
        public Albums()
        {
            AlbumsSongs = new HashSet<AlbumSongs>();
        }
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public  List<Albums> GetAlbums { get; set; }
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }
        public string AlbumTitle { get; set; }
        public DateTime AlbumYear { get; set; }
        public virtual ICollection<AlbumSongs> AlbumsSongs { get; set; }
        public virtual Artist IdArtistNavigation { get; set; }
    }
}
