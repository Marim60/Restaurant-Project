using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Models
{
    [Table("OrderStatus")]

    public class OrderStatus
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z ]{3,20}$", ErrorMessage = "Name must be only charcter. and range charcter between 3 and 20")]
        public string Name { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
