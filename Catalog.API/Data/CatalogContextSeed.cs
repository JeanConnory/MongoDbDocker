using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
                productCollection.InsertManyAsync(GetMyProducts());
        }


        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product { Id = "602d2149e773f2a3990b47f5", Name = "Iphone 15", Category = "Smartphone", Description = "Novo Apple Iphone 15", Image = "Product1.png", Price = 950.00M},
                new Product { Id = "602d2149e773f2a3990b47f6", Name = "Samsung S24", Category = "Smartphone", Description = "Novo Samsung Galaxy S24", Image = "Product2.png", Price = 900.00M},
                new Product { Id = "602d2149e773f2a3990b47f7", Name = "Alienware m16", Category = "Notebook", Description = "Novo Alienware m16", Image = "Product3.png", Price = 1299.00M}
            };
        }
    }
}
