using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApiProj.Models
{
    
    public class ProductCategory
    {
        [Key]
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
