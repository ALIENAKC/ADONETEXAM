using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public partial class Genres
    {
        public Genres()
        {
            Artists = new HashSet<Artist>();
        }
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public virtual Album IdGenreNavigation { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }

    }
}