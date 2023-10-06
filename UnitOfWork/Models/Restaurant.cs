using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Models
{
    [Table("Restaurant")]

    public class Restaurant
    {
        public int Id { get; set; }
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Name must be only charcter. and range charcter between 3 and 20")]
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage = "Description must be less than 300 charcters.")]
        public string? Description { get; set; }
        [Required]
        public string? Location { get; set; }
        public DateTime? CreatedAt { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<Category>? Categories { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }


    }
}
