using System;

namespace Lab3
{
    public class Book
    {
        public int Id {get; private set;}
        public Char[] Name {get; private set;}
        public String Description {get; private set;}
        public double Price {get; private set;}
        public int Year {get; private set;}
        public Generes Genre { get; private set; }
        public enum Generes { science, action, story, kids, manual };


        public Book(){
            Id=0;
            Name = new char[100];
            Name = "No name".ToCharArray();
            Description="No description";
            Price=0.0;
            Year=0;
        }

        public Book(int id, string name, string description, double price, int year)
        {
            Id = id;
            Name = name.ToCharArray();
            Description = description;
            Price = price;
            this.Year = year;
        }

    }
}
