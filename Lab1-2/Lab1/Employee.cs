using System;

namespace Lab1
{
    public class Employee
    {
        public int Id {get; private set;}
        public String FirstName {get; private set;}
        public String LastName{get; private set;}
        public DateTime StartDate {get; private set;}
        public DateTime EndDate {get; private set;}
        public double Salary {get; private set;}

        public Employee(int id, String firstName, String lastName, DateTime start, DateTime end, double salary)
        {
            Id=id;

            if(String.IsNullOrEmpty(firstName))
                FirstName="First name not known.";
            else
                FirstName=firstName;

            if(String.IsNullOrEmpty(lastName))
                LastName="Last name not known.";
            else
                LastName=lastName;
 
            StartDate=start;
            EndDate=end;
            Salary=salary;
        }
        public virtual string Salutation()
        {
            return "Hello, employee";
        }
    }
}
