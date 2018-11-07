using System;

namespace Lab6.Data
{
    public interface IPoi
    {
        City City { get; set; }
        Guid? CityId { get; set; }
        string Description { get; }
        Guid Id { get; }
        string Name { get; }
    }
}