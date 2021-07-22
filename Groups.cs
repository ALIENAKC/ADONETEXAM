using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public partial class Groups
    {
        public int ArtistID { get; set; }
        public string GroupName { get; set; }
        public virtual Album IdArtistNavigation { get; set; }

    }
}