using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApiProj.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [Required]
        public Guid EmployeeId { get; set; }


        public virtual Employee Employee { get; set; }
        public List<OrderProduct> Products { get; set; }

    }
}
