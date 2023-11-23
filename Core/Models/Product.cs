using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? BrandName { get; set; }
        public string? Description { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string? Type { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? Industry { get; set; }
        [ForeignKey("Branch")]
        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }

    }
}
