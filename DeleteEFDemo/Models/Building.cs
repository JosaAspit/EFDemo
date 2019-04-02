using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeleteEFDemo.Models
{
    public class Building 
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Animal> Animals { get; set; }
        public Farm Farm { get; set; }
    }
}
