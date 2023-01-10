using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Name
    /// * Department [Die ersten 3 Zeichen von Name]
    /// * Guid
    /// (4P)
    /// </summary>
    public class Shop : EntityBase
    {
        //TODO: Implementation

        public string Name { get; set; } = string.Empty;

        public string Department
        {
            get
            {
                if (Name.Length >= 3)
                {
                    return Name?.Substring(0, 3).ToUpper() ?? "--";
                }
                return "--";
            }
        }

        public Guid Guid { get; set; }

        private List<User> _user = new();

        public IReadOnlyList<User> Users => _user;

        private List<Product> _products = new();

        public IReadOnlyList<Product> Products => _products;

        protected Shop()
        { }

        public Shop(string name, Guid guid)
        {
            Name = name;
            Guid = guid;
        }
    }
}
