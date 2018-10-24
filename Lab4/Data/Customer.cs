using System;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Customer
    {
        public Customer(string Name, string Address, string PhoneNumber, string Email)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }

        public Guid Id { get; private set; }

        public string Name { get; set; }

        public string Address { get; private set; }

        [RegularExpression(@"+40+0\d{9}$")]
        public string PhoneNumber { get; private set; }

        [RegularExpression(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}")]
        public string Email { get; private set; }

    }
}
