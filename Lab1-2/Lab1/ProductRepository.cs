using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab1
{
    public class ProductRepository
    {
        List<Product> products;

        public ProductRepository() {
            products = new List<Product>();
        }

        public void AddProduct(Product toAdd)
        {
            products.Add(toAdd);
        }

        public Product GetProductByPosition(int position)
        {
            return products.ElementAt(position);
        }

        public void RemoveProductByName(string toRemove)
        {
            products.RemoveAll(p => p.Name == toRemove);
        }

        public Product GetProductByName(string toFind)
        {
            return products.Find(i => i.Name == toFind);
        }

        public List<Product> FindAllProducts()
        {
            return products;
        }
    }
}
