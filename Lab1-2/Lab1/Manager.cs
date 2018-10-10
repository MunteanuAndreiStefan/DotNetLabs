using System;

namespace Lab1
{
    public class Manager : Employee, IGetFullName, IActiveIs
    {
        public String TeamName {get; private set;}
        public int TeamSize {get; private set;}
        public Manager (int id, String firstName, String lastName, DateTime start, DateTime end, double salary, String teamName, 
        int teamSize) : base(id,firstName, lastName, start, end, salary)
        {
            if(String.IsNullOrEmpty(teamName))
            {
                TeamName="No team";
                TeamSize=0;
            }
            else
            {
                TeamName=teamName;
                TeamSize=teamSize;
            }    
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
            return "Hello, Manager";
        }
    }
}
