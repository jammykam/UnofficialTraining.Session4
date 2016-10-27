using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace UnofficialTraining.Session4.Data.Interfaces
{
    [SitecoreType(AutoMap = true)]
    public interface IRelatedItemConfiguration : IGlassBase
    {
        string Title { get; set; }
        string SubTitle { get; set; }
        IPage FilterRoot { get; set; }
        bool CheckboxSample { get; set; }
        IEnumerable<IGlassBase> TreelistSample { get; set; }
    }
}