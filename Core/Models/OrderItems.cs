using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public decimal? SubTotalPrice { get; set; }
        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
