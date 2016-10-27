using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace UnofficialTraining.Session4.Data.Interfaces
{
    [SitecoreType(AutoMap = true)]
    public interface IPage : IGlassBase
    {
        string BrowserTitle { get; set; }

        string MetaTitle { get; set; }

        string MetaDescription { get; set; }
        
        string SummaryTitle { get; set; }

        string SummaryDescription { get; set; }

        IEnumerable<ILookupItem> ProductTags { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string TemplateName { get; set; }

        IEnumerable<IPage> Children { get; set; }
    }
}
