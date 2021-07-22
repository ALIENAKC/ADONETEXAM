using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public partial class Country
    {
        public Country()
        {
            Artists = new HashSet<Artist>();
        }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }
    }
}