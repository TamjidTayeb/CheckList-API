using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Item
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public Boolean completed { get; set; }

    }
}
