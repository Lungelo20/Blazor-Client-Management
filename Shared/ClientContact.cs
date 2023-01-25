using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTT.Shared
{
    public class ClientContact
    {
        public int Id { get; set; }
        public string ContactType { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public int Status { get; set; }
        public int ClientDetailsId { get; set; }
    }
}
