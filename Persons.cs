using System;
using System.Collections.Generic;
using System.Text;

namespace ADONETEXAM.Models
{
    public class Persons
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public List<Persons> GetPersons { get; set;}

    }
}
