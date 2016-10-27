using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace UnofficialTraining.Session4.Data.Interfaces.RenderingParameters
{

    [SitecoreType(TemplateId = "7F705D6C-AA86-4DBE-9B74-EA7D72C7B881", AutoMap = true)]
    public interface IRelatedContentFilter
    {
        IEnumerable<ILookupItem> Tags { get; set; }
        int DisplayCount { get; set; }
    }
}