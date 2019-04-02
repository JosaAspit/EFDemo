using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeleteEFDemo.Models
{
    public class Animal
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }
        public Building Building { get; set; }
    }
}
