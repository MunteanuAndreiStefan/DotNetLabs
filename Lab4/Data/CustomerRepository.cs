using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class CustomerRepository
    {
        public CustomerContext productManagement;
        public CustomerRepository(CustomerContext productManagement)
        {
            this.productManagement = productManagement;
        }

        public void Create(Customer customer)
        {
            this.productManagement.Customers.Add(customer);
            this.productManagement.SaveChanges();
        }

        public void Update(Customer customer)
        {
            Customer updatedCustomer = this.productManagement.Customers.Find(customer.Id);
            updatedCustomer.Name = "BlaBla";
            this.productManagement.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            this.productManagement.Customers.Remove(customer);
            this.productManagement.SaveChanges();
        }

        public Customer GetById(Guid id)
        {
            return this.productManagement.Customers.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return this.productManagement.Customers;
        }

        public Customer GetCustomerByEmail(string email)
        {
            return this.productManagement.Customers.Where(customer => customer.Email == email).First();
        }
    }
}
