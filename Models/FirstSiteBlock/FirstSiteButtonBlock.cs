using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project.Models.Blocks;

/// <summary>
/// Used to insert a link which is styled as a button
/// </summary>
[SiteContentType(GUID = "3340ce15-4ccc-4ab7-9682-57d105752803")]
[SiteImageUrl]
public class FirstSiteButtonBlock : SiteBlockData
{
    [Display(Order = 1, GroupName = SystemTabNames.Content)]
    [Required]
    public virtual string ButtonText { get; set; }

    [Display(Order = 2, GroupName = SystemTabNames.Content)]
    [Required]
    public virtual Url ButtonLink { get; set; }
}
