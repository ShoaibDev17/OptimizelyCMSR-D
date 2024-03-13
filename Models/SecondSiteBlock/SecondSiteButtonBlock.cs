using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project.Models.Blocks;

/// <summary>
/// Used to insert a link which is styled as a button
/// </summary>
[SiteContentType(GUID = "df38a31a-2ef3-4db8-bb31-43ae2dc9f996")]
[SiteImageUrl]
public class SecondSiteButtonBlock : SiteBlockData
{
    [Display(Order = 1, GroupName = SystemTabNames.Content)]
    [Required]
    public virtual string ButtonText { get; set; }

    [Display(Order = 2, GroupName = SystemTabNames.Content)]
    [Required]
    public virtual Url ButtonLink { get; set; }
}
