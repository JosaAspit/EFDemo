using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeleteEFDemo.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public Farm Farm { get; set; }
        public string Name { get; set; }
    }
}
