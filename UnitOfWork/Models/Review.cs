using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Models
{
    [Table("Review")]

    public class Review
    {
        public int Id { get; set; }
        [Required]
        public int Rate { get; set; }
        [MaxLength(300, ErrorMessage = "Description must be less than 300 charcters.")]
        [Required]
        public string? Comment { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
    }
}
