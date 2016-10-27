using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace UnofficialTraining.Session4.Data.Interfaces.RenderingParameters
{
    [SitecoreType(TemplateId = "176C2C2F-5ACF-442A-BBC4-80DC153A77A3", AutoMap = true)]
    public interface IComponentStyling
    {
        ILookupItem Style { get; set; }
        Image Icon { get; set; }
    }
}