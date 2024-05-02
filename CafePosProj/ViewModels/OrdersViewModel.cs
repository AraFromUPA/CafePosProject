using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApiProj.ViewModels
{
    public class OrdersViewModel
    {
        public Guid Id { get; set; }
        public string Customer { get; set; }
        public string Employee { get; set; }
        
    }
}
