using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RTT.Shared
{
    public class ClientDetails
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int Status { get; set; }
        public List<ClientAddress> Addresses { get; set; } = new List<ClientAddress>();
        public List<ClientContact> Contacts { get; set; } = new List<ClientContact>();
    }
}
