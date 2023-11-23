using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User:IdentityUser<int>
    {
        public string? FullName { get; set; }
        [ForeignKey("Branch")]
        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }
        public IEnumerable<HR> HRs { get; set; } = new HashSet<HR>();
        public IEnumerable<Expense> Expenses { get; set; } = new HashSet<Expense>();
    }
}
