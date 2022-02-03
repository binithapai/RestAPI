using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudapi.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public byte[] imagePath { get; set; }

        public string ingredients { get; set; }

    }
}
