using System;
using System.Linq;

namespace Lab5
{
    public class CityRepository
    {

        ApplicationContext applicationContext;

        public CityRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public void CreateCity(string name,string description,double latitude,double longitude)
        {
            this.applicationContext.Cities.Add(new City(name, description, latitude, longitude));
        }

        public void RemoveCity(Guid guid)
        {
            City city= this.applicationContext.Cities.Where(c => c.Id == guid).First();
            this.applicationContext.Cities.Remove(city);
        }

    }
}
