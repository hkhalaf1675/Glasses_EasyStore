using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public IEnumerable<Product> Products { get; set; } = new HashSet<Product>();
        public IEnumerable<User> Users { get; set; } = new HashSet<User>();
        public IEnumerable<Order> Orders { get; set; } = new HashSet<Order>();
        public IEnumerable<Expense> Expenses { get; set; } = new HashSet<Expense>();
    }
}
