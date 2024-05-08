using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class Payment
    {
        private Guid Id { get; set; }

        private Guid OrderId { get; set; }
        private Guid AddressId { get; set; }
        private Method PayMethod { get; set; }
        private decimal Amount { get; set; }
        private DateTime CreatedAt { get; set; } = DateTime.Now;
        private DateTime ReceivedAt { get; set; }
        private PaymentStatus Status { get; set; }
    }

    public enum Method
    {
        Cash
        ,
        Credit
    }
    public enum PaymentStatus
    {
        Paid,
        Unpaid
    }
}