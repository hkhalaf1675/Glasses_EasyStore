using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public decimal? TotalOutput { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User? User { get; set; }
        [ForeignKey("Branch")]
        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }

        public IEnumerable<ExpensesOutput> expensesOutputs { get; set; } = new HashSet<ExpensesOutput>();
    }
}
