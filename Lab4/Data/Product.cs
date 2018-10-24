using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data
{
    public class Product
    {
        public Product(string Name, string Description, DateTime StartDate, DateTime EndDate, double Price, int Vat)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Price = Price;
            this.Vat = Vat;
        }
    
        public Guid Id { get; private set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; private set; }

        [Required]
        public DateTime StartDate { get; private set; }

        public DateTime? EndDate { get; private set; }

        [Required]
        public double Price { get; private set; }

        [Required]
        public int Vat { get; private set; }

        public bool IsValid()
        {
            return EndDate > StartDate;
        }

        public double ComputeVat()
        {
            return Price * Vat / 100;
        }
    }
}
