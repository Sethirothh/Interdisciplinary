using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interdisciplinary.Models
{
    public class Food
    {
        public int FoodID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Picture { get; set; }

        public decimal Price { get; set; }

        public string Location { get; set; }

        public int CategoryID { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

        public Category Category { get; set; }
    }
}
