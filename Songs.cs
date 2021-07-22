using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public partial class Songs
    {
        public Songs()
        {
            AlbumsSongs = new HashSet<AlbumSongs>();
        }
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public int SongDuration { get; set; }
        public virtual ICollection<AlbumSongs> AlbumsSongs { get; set; }
    }
}