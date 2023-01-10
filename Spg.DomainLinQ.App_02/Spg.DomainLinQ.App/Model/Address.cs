using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Street
    /// * Zip
    /// * City
    /// * BuildungNumber
    /// (2P)
    /// </summary>
    public class Address
    {
        // TODO: Implementation

        public string Street = string.Empty;


        public string Zip = string.Empty;

        public string City = string.Empty;

        public Address()
        { }

        public Address(string street, string zip, string city)
        {
            Street = street;
            Zip = zip;
            City = city;
        }
    }
}
