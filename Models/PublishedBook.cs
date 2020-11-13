using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TobiasV_Victor_Lab2.Models
{
    public class PublishedBook
    {
        public int PublisherID { get; set; }
        public int BookId { get; set;}
        public Publisher Publisher { get; set; }
        public Book Book { get; set; }
    }
}
