using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using UnofficialTraining.Session4.Data.Interfaces;
using UnofficialTraining.Session4.Data.Interfaces.RenderingParameters;
using UnofficialTraining.Session4.Data.ViewModels;

namespace UnofficialTraining.Session4.Controllers
{
    public class WidgetController : GlassController
    {
        public ActionResult RelatedContent()
        {
            var configItem = GetDataSourceItem<IRelatedItemConfiguration>();
            var viewModel = GetRelatedArticles(configItem);
            
            return PartialView("~/Views/Components/Widgets/RelatedContentWidget.cshtml", viewModel);
        }

        public ActionResult RelatedTaggedContent()
        {
            var configItem = GetDataSourceItem<IRelatedItemConfiguration>();
            var parameters = GetRenderingParameters<IRelatedContentFilter>();
            
            var viewModel = GetRelatedTaggedContent(configItem, parameters);

            return PartialView("~/Views/Components/Widgets/TaggedContentWidget.cshtml", viewModel);
        }


        //*************************************************************
        // Please don't do this, this is just for demo
        // In a real world situation, logic should not be 
        // in the controller and if you do this a poor kitten dies
        //*************************************************************

        private RelatedContent GetRelatedArticles(IRelatedItemConfiguration configItem)
        {
            RelatedContent viewModel = new RelatedContent(configItem, null);

            if (configItem.FilterRoot != null)
            {
                foreach (var item in configItem.FilterRoot.Children)
                {
                    if (item.TemplateName == "ArticlePage")
                    {
                        viewModel.RelatedItems.Add(item);
                    }
                }
            }

            return viewModel;
        }

        private RelatedContent GetRelatedTaggedContent(IRelatedItemConfiguration configItem, IRelatedContentFilter parameters)
        {
            int count = 0;
            RelatedContent viewModel = new RelatedContent(configItem, parameters);

            foreach (var item in configItem.FilterRoot.Children)
            {
                if (count == parameters.DisplayCount)
                    break;

                if (parameters.Tags.Select(x => x.Text).Intersect(item.ProductTags.Select(x => x.Text)).Any())
                {
                    viewModel.RelatedItems.Add(item);
                    count++;
                }
            }

            return viewModel;
        }
    }
}
