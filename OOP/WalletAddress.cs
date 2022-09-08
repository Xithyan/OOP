using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class WalletAddress
    {
        public WalletType Type { get; set; }
        public string? Link { get; set; }
        public string? Password { get; set; }
        public List<WalletAddress> WalletAddresses { get; set; } = new();
    }
}
