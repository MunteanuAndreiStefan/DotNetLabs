using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    using DataLayer;

    public interface ICityRepository
    {
        void Create(City City);
        void Delete(City CityId);
        City GetById(Guid id);
        IReadOnlyList<City> GetAll();
    }
}
