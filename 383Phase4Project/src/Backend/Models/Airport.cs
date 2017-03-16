using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Airport
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShorterName { get; set; }
        public string ThreeLetterCode { get; set; } 
    }
}
