using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aashishtoshniwal_46129010_customerqueue
{
    public class CustomerDetails : IEquatable<CustomerDetails>
    {
        public string Name { get; set; }
        public string Email { get; set; } 
        public long Phone { get;set; }

        public CustomerDetails(string name, string email, long phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{Name} {Email} {Phone}";
        }


        public bool Equals(CustomerDetails customerTocompare)
        {
            bool isSameCustomer = (Phone == customerTocompare.Phone);
            return isSameCustomer;
        }
    }
}
