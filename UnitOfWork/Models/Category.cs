using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Models
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Name must be only charcter. and range charcter between 3 and 20")]
        public string Name { get; set; }
        [MaxLength(300, ErrorMessage = "Description must be less than 300 charcters.")]
        [Required]
        public string? Description { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        public virtual ICollection<Item>? Items { get; set; }

    }
}
