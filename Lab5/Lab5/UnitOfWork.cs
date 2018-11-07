using System;

namespace Lab5
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        readonly ApplicationContext context = new ApplicationContext();
        CityRepository citiesRepository;
        PoiRepository poiRepository;

        public CityRepository Cities
        {
            get { return this.citiesRepository ?? (this.citiesRepository = new CityRepository(context)); }
        }

        public PoiRepository Pois
        {
            get { return this.poiRepository ?? (this.poiRepository = new PoiRepository(context)); }
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
