using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber (PK)
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * BillingAddress
    /// * BusinessAddress
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class User
    {
        // TODO: Implementation

        public int RegistrationNumber { get; private set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public Address BillingAddress { get; set; } = default!;

        public Address BusinessAddress { get; set; } = default!;

        public string AccountName => $"{LastName.Substring(0, 5)}{RegistrationNumber}";

        public Genders Genders { get; set; } 

        public Guid Guid { get; set; }

        private List<Product> _products = new();

        public void AddProduct(List<Product> product)
        {
            _products.AddRange(product);
        }

        public IReadOnlyList<Product> Products => _products;

        public Shop ShopNavigation { get; set; } = default!;

        public int ShopNavigationId { get; set; }

        protected User()
        {
        }

        public User(int registrationNumber, 
            string firstName, 
            string lastName, 
            string email, 
            Address billingAddress,
            Address businessAddress, 
            Genders genders, 
            Guid guid, 
            Shop shopNavigation)
        {
            RegistrationNumber = registrationNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BillingAddress = billingAddress;
            BusinessAddress = businessAddress;
            Genders = genders;
            Guid = guid;
            ShopNavigation = shopNavigation;
        }
    }
}
