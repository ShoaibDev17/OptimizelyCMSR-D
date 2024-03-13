using System.ComponentModel.DataAnnotations;
using Optimizely_Project.Models.Blocks;
using EPiServer.SpecializedProperties;

namespace Optimizely_Project.Models.Pages;

/// <summary>
/// Used for the site's start page and also acts as a container for site settings
/// </summary>
[ContentType(
    GUID = "c1325cbc-4d83-45bd-b681-a886c2dd08bc",
    GroupName = Globals.GroupNames.Specialized)]
public class ErrorPage : SitePageData
{
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 320)]
    [CultureSpecific]
    public virtual ContentArea MainContentArea { get; set; }
}
