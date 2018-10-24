using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class ProductRepository
    {
        CustomerContext productManagement;
        public ProductRepository(CustomerContext productManagement)
        {
            this.productManagement = productManagement;
        }
        public void Create(Product product)
        {
            this.productManagement.Products.Add(product);
            this.productManagement.SaveChanges();
        }
        public void Update(Product product)
        {
            Product updatedProduct = this.productManagement.Products.Find(product.Id);
            updatedProduct.Name = "BlaBla";
            this.productManagement.SaveChanges();
        }
        public void Delete(Product product)
        {
            this.productManagement.Products.Remove(product);
            this.productManagement.SaveChanges();
        }
        public Product GetById(Guid id)
        {
            return this.productManagement.Products.Find(id);
        }
        public IEnumerable<Product> GetAll()
        {
            return this.productManagement.Products;
        }
        public IEnumerable<Product> GetProductsByPrice(double price)
        {
            return this.productManagement.Products.Where(product => product.Price == price);
        }
    }
}
