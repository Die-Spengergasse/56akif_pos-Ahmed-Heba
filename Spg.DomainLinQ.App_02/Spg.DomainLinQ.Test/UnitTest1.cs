using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;
using System;

namespace Spg.DomainLinQ.Test
{
    public class UnitTest1
    {
        private Shop2000Context GenerateDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source = Shop2000.db");
            Shop2000Context db = new Shop2000Context(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            return db;
        }

        [Fact]
        public void Test_Shop()
        {
            // 1. Arrange
            Shop2000Context db = GenerateDb();
            Shop newShop = new Shop("Shop1", Guid.NewGuid());

            // 2. Act
            db.Shops.Add(newShop);
            db.SaveChanges();

            // 3. Assert 

            Assert.Equal(1, db.Shops.Count());
        }

         [Fact]
         public void Test_Product()
         {          
            // 1. Arrange

             Shop2000Context db = GenerateDb();
            Product newProduct = new Product("Katzenfutter", 1, 1, DateTime.UtcNow.AddDays(50), DateTime.Now, 12.50M, new Shop("Shop1", Guid.NewGuid()));
             
            // 2. Act
             db.Products.Add(newProduct);
             db.SaveChanges();

             // 3. Assert 
 
             Assert.Equal(1, db.Products.Count());
         }

        [Fact]
        public void Test_User()
        {

            // 1. Arrange

            Shop2000Context db = GenerateDb();
            User newUser = new User(1, "Mustermann", "Max", "eMail@", new Address("Streetgasse", "1100", "Wien"), new Address("Streetgasse", "2453", "NÖ"), Genders.FEMALE, Guid.NewGuid(), new Shop("Shop1", Guid.NewGuid()));

            // 2. Act
            db.Users.Add(newUser);
            db.SaveChanges();

            // 3. Assert 

            Assert.Equal(1, db.Users.Count());
        }

        [Fact]
        public void Test_Spupplier()
        {

            // 1. Arrange

            Shop2000Context db = GenerateDb();
            Supplier newSupplier = new Supplier("Musterfrau", "Susi", "eMail@", Guid.NewGuid(), new Address("Maxgasse", "1100", "Wien"), new Address("Armgasse", "2553", "NÖ"));

            // 2. Act
            db.Suppliers.Add(newSupplier);
            db.SaveChanges();

            // 3. Assert 

            Assert.Equal(1, db.Suppliers.Count());
        }

        [Fact]
        public void Test_Price()
        {
            // 1. Arrange

            Shop2000Context db = GenerateDb();
            Price newPrice = new Price(21.50M, 20, DateTime.Now, Guid.NewGuid(), new Product("Katzenfutter", 1, 1, DateTime.UtcNow.AddDays(50), DateTime.Now, 12.50M, new Shop("Shop1", Guid.NewGuid())));

            // 2. Act
            db.Prices.Add(newPrice);
            db.SaveChanges();

            // 3. Assert 

            Assert.Equal(1, db.Prices.Count());
        }
    }
}