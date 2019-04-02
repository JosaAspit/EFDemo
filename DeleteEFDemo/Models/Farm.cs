using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeleteEFDemo.Models
{
    public class Farm
    {
        public int Id { get; set; }
        public List<Building> Buildings { get; set; }
        public List<Worker> Workers { get; set; }
        public string Name { get; set; }
    }
}
