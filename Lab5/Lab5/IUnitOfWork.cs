using Lab5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public interface IUnitOfWork
    {
        CityRepository Cities { get; }
        PoiRepository Pois { get; }
        void Save();
    }
}