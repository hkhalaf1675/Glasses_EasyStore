using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ExpensesOutput
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public int? Quantity { get; set; }
        public decimal? SubTotalPrice { get; set; }
        [ForeignKey("Expense")]
        public int? ExpenseId { get; set; }
        public Expense? Expense { get; set; }
    }
}
