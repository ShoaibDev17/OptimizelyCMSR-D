using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc.Html;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Optimizely_Project.Business.Rendering
{
    [ServiceConfiguration(ServiceType = typeof(FormContentAreaRender), Lifecycle = ServiceInstanceScope.Singleton)]
    public class FormContentAreaRender : ContentAreaRenderer
    {
        private IContent _currentContent;

        /// Get css of a content area item
        public string GetItemCssClass(HtmlHelper html, ContentAreaItem areaItem)
        {
            var tag = GetContentAreaItemTemplateTag(html, areaItem);
            var baseClasses = base.GetContentAreaItemCssClass(html, areaItem);
            return $"block {GetTypeSpecificCssClasses(areaItem)} {tag} {baseClasses}";
        }

        /// Get layout width of a content area item
        public int GetColumnWidth(HtmlHelper html, ContentAreaItem item)
        {
            var tag = GetContentAreaItemTemplateTag(html, item);
            return GetColumnWidth(tag);
        }

        private string GetTypeSpecificCssClasses(ContentAreaItem contentAreaItem)
        {
            var content = GetCurrentContent(contentAreaItem);
            var cssClass = content?.GetOriginalType().Name.ToLowerInvariant() ?? string.Empty;
            var customClassContent = content as ICustomCssInContentArea;
            if (customClassContent != null && !string.IsNullOrWhiteSpace(customClassContent.ContentAreaCssClass))
            {
                cssClass += $" {customClassContent.ContentAreaCssClass}";
            }
            return cssClass;
        }

        private IContent GetCurrentContent(ContentAreaItem contentAreaItem)
        {
            if (_currentContent == null || !_currentContent.ContentLink.CompareToIgnoreWorkID(contentAreaItem.ContentLink))
            {
                _currentContent = contentAreaItem.GetContent();
            }
            return _currentContent;
        }

        /// Get the width of a css tag (bootstrap column width)
        private int GetColumnWidth(string tag)
        {
            if (Globals.FormTags.FullWidth.Contains(tag))

            {
                return 12;
            }
            if (Globals.FormTags.ThirdQuaterWidth.Contains(tag))
            {
                return 9;
            }
            if (Globals.FormTags.TwoThirdsWidth.Contains(tag))
            {
                return 8;
            }
            if (Globals.FormTags.HalfWidth.Contains(tag))
            {
                return 6;
            }
            if (Globals.FormTags.OneThirdWidth.Contains(tag))
            {
                return 4;
            }
            if (Globals.FormTags.OneQuaterWidth.Contains(tag))
            {
                return 3;
            }
            return 12;
        }
    }
}
