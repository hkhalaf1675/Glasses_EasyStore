using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CustomerAppointment
    {
        public int Id { get; set; }
        public string? DoctorName { get; set; }
        public float? Right_SPH { get; set; }
        public float? Right_CYL { get; set; }
        public float? Right_AX { get; set; }
        public float? Left_SPH { get; set; }
        public float? Left_CYL { get; set; }
        public float? Left_AX { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
