using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Interdisciplinary.Models
{
    public class Food
    {

        public int FoodID { get; set; }

        public string Title { get; set; }

        [StringLength(40, MinimumLength = 10, ErrorMessage = "Content cannot be less than 10 characters and longer than 40 characters")]
        [Required] 
        public string Content { get; set; }

        public string Picture { get; set; }

        [Range(1, 100, ErrorMessage = "The field price must be a number and it must be between 1 and 100")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string Location { get; set; }

        public int CategoryID { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

        public Category Category { get; set; }
    }
}
