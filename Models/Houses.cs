using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPractice.Models
{
    public class Houses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int sellRent { get; set; }
        public string image { get; set; }
    }
}
