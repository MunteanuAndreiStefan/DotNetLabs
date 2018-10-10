using System;

namespace Lab1
{
    public class Product
    {
        public int Id {get; private set;}
        public String Name {get; private set;}
        public String Description {get; private set;}
        public DateTime StartDate {get; private set;}
        public DateTime EndDate {get; private set;}
        public double Price {get; private set;}
        public int VAT {get; private set;}

        public Product(){
            Id=0;
            Name="No name";
            Description="No description";
            StartDate = new DateTime(1996, 10, 22);
            EndDate=StartDate.AddDays(10);
            Price=0.0;
            VAT=0;
        }

        public bool IsValid(){
            if(StartDate<=EndDate && DateTime.Now<EndDate && DateTime.Now>StartDate)
                return true;
            return false;
        }

        public double ComputeVAT(){
            return Price*VAT/100+Price;
        }

    }
}
