using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Contact : Object
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? BusinessName { get; set; }

        public DateTime? BirthDay { get; set; }

        public List<Address> Addresses { get; set; } = new();

        public List<PhoneNumber> PhoneNumbers { get; set;} = new(); 

        public List<WalletAddress> WalletAddresses { get; set; } = new();
    }
}
