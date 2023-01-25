using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTT.Shared
{
    public class ClientAddress
    {
        public int Id { get; set; }
        public string AddressType { get; set; } = string.Empty;
        public string LineOne { get; set; } = string.Empty;
        public string LineTwo { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int Status { get; set; }
        public int ClientDetailsId { get; set; }
    }
}
