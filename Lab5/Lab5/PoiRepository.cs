using System;
using System.Linq;

namespace Lab5
{
    public class PoiRepository
    {

        ApplicationContext applicationContext;

        public PoiRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public void AddPoi(Poi poi)
        {
            this.applicationContext.Pois.Add(poi);
        }

        public void RemovePoi(Guid guid)
        {
            Poi poi = this.applicationContext.Pois.Where(p => p.Id == guid).First();
            this.applicationContext.Pois.Remove(poi);
        }

    }
}
