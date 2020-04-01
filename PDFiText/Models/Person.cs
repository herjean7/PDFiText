using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDFiText.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public char Gender { get; set; }
        public string Nationality { get; set; }
    }
}
