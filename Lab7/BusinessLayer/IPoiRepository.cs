using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    using DataLayer;

    public interface IPoiRepository
    {
        void Create(Poi Poi);
        void Delete(Poi PoiId);
        IReadOnlyList<Poi> GetAll();
        Poi GetById(Guid id);
    }
}
