using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PromotionEngine.IProductServices;
using PromotionEngine.Models;

namespace PromotionEngineTests
{
    public class Tests
    {
        List<Product> products = new List<Product>();
        ProductServices productServices = new ProductServices();

        [Test]
        public void Scenario1()
        {
            string type = "";
            Product p = new Product(type);
            Product p1 = new Product(type);
            Product p2 = new Product(type);
            p.Id = "A";
            products.Add(p);
            p1.Id = "B";
            products.Add(p1);
            p2.Id = "C";
            products.Add(p2);
            var totalprice = productServices.GetTotalPrice(products);
            Assert.IsNotEmpty(totalprice.ToString());
        }

        [Test]
        public void Scenario2()
        {
            string type = "";
            Product p = new Product(type);
            Product p1 = new Product(type);
            Product p2 = new Product(type);
            p.Id = "A";
            products.AddRange((IEnumerable<Product>)Enumerable.Repeat(p, 5));
            p1.Id = "B";
            products.AddRange((IEnumerable<Product>)Enumerable.Repeat(p1, 5));
            p2.Id = "C";
            products.Add(p2);
            var totalprice = productServices.GetTotalPrice(products);
            Assert.IsNotEmpty(totalprice.ToString());
        }
    }
}
