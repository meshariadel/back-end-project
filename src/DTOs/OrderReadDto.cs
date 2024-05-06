using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderReadDto 
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPirce { get; set; }

    }
}