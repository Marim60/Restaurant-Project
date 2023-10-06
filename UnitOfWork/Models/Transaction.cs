using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Models
{
    [Table("Transaction")]

    public class Transaction
    {
        public int Id { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [NotMapped]
        public decimal TotalPrice { get; set; }
        public int OrderId { get; set; }

        public virtual Order? Order { get; set; }
    }
}
