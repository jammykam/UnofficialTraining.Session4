using System;
using System.Collections.Generic;
using UnofficialTraining.Session4.Data.Interfaces;
using UnofficialTraining.Session4.Data.Interfaces.RenderingParameters;

namespace UnofficialTraining.Session4.Data.ViewModels
{
    public class RelatedContent
    {
        public RelatedContent(IRelatedItemConfiguration content, IRelatedContentFilter parameters)
        {
            Content = content;
            Parameters = parameters;
            RelatedItems = new List<IPage>();
        }

        public IRelatedItemConfiguration Content { get; set; }

        public IRelatedContentFilter Parameters { get; set; }

        public IList<IPage> RelatedItems { get; set; }
    }
}
