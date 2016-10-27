using Glass.Mapper.Sc.Configuration.Attributes;

namespace UnofficialTraining.Session4.Data.Interfaces
{
    [SitecoreType(AutoMap = true)]
    public interface IGenericContent : IGlassBase
    {
        string Title { get; set; }
        string Text { get; set; }
    }
}