using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace UnofficialTraining.Session4.Data.Interfaces
{
    [SitecoreType(AutoMap = true)]
    public interface IFeatureWidget : IGlassBase
    {
        string Title { get; set; }
        string Description { get; set; }
        Image Image { get; set; }
    }
}