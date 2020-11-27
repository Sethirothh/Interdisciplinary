using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interdisciplinary.Models
{
    public class FoodTag
    {
        public int FoodTagID { get; set; }

        public int TagID { get; set; }

        public int FoodID { get; set; }

        public Food Food { get; set; }

        public Tag Tag { get; set; }

    }
}
