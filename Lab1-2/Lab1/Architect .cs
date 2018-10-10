using System;

namespace Lab1
{
    public class Architect : Employee, IGetFullName, IActiveIs
    {
        public String Country {get; private set;}
        public int Rank {get; private set;}
        public int YearsOfExperience {get; private set;}
        public int NumberOfProjectsWorkingOn {get; private set;}
        public Architect (int id, String firstName, String lastName, DateTime start, DateTime end, double salary, String country, 
        int rank, int yearsOfExp, int nrOfProj) : base(id,firstName, lastName, start, end, salary)
        {
            if(String.IsNullOrEmpty(country))
                Country="No known country.";
            else
                Country=country;

            Rank=rank;
            YearsOfExperience=yearsOfExp;
            NumberOfProjectsWorkingOn=nrOfProj;
        }

        public String GetFullName(){
            return "First name: "+ FirstName+ " Last name:  "+LastName + "\n";
        }
        public bool IsActive(){
            if(StartDate<=EndDate && DateTime.Now<EndDate && DateTime.Now>StartDate)
                return true;
            return false;
        }

        public override string Salutation()
        {
            return "Hello, Architect";
        }
    }
}
