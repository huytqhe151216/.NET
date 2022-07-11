using System;
using System.Collections.Generic;

#nullable disable

namespace BtNorthwind.Models
{
    public partial class CustomerCustomerDemo
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public virtual Customer1 Customer { get; set; }
        public virtual CustomerDemographic CustomerType { get; set; }
    }
}
