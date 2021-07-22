using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public partial class AlbumSongs
    {
        public int AlbumID { get; set; }
        public int SongID { get; set; }
      
        public virtual Album IdAlbumNavigation { get; set; }
        public virtual Songs IdSongNavigation { get; set; }

    }
}