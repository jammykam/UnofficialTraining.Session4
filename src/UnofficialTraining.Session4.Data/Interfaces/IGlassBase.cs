using System;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace UnofficialTraining.Session4.Data.Interfaces
{
    [SitecoreType(AutoMap = true)]
    public interface IGlassBase
    {
        Guid Id { get; set; }
    }
}