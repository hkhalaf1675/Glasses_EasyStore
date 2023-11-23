using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal? TotalPrice { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User? User { get; set; }
        [ForeignKey("Branch")]
        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }

        public IEnumerable<OrderItems> OrderItems { get; set; } = new HashSet<OrderItems>();
    }
}
