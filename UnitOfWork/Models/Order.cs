using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Models
{
    [Table("Order")]

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        [NotMapped]
        public decimal TotalPrice { get; set; }
        public int RestaurantId { get; set; }
        public int OrderStatusId { get; set; }

        public virtual Restaurant? Restaurant { get; set; }
        public virtual OrderStatus? OrderStatus { get; set; }
        public virtual Transaction? Transaction { get; set; }

    }
}
