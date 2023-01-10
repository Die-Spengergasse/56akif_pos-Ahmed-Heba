using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Description (PK)
    /// * Ean13;
    /// * Stock;
    /// * ExpiryDate;
    /// * DeliveryDate;
    /// * Price;
    /// * ShopNavigation
    /// (4P)
    /// </summary>
    public class Product
    {
        // TODO: Implementation

        public string Description { get; private set; } = string.Empty;

        public int Ean13 { get; set; }

        public int Stock { get; set; }

        public DateTime ExpiryDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public decimal Price { get; set; }

        //1
        public Shop ShopNavigation { get; set; } = default!;

        public int ShopNavigationId { get; set; }

        //2
        private List<User> _user = new();

        public IReadOnlyList<User> Users => _user;

        //3
        private List<Supplier> _supplier = new();

        public IReadOnlyList<Supplier> Suppliers => _supplier;

        //4
        private List<Price> _price= new();

        public IReadOnlyList<Price> Prices => _price;

        protected Product()
        { }

        public Product(string description, 
            int ean13, 
            int stock, 
            DateTime expiryDate, 
            DateTime deliveryDate, 
            decimal price, Shop shopNavigation)
        {
            Description = description;
            Ean13 = ean13;
            Stock = stock;
            ExpiryDate = expiryDate;
            DeliveryDate = deliveryDate;
            Price = price;
            ShopNavigation = shopNavigation;
        }
    }
}
