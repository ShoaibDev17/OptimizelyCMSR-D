using EPiServer.Forms.Implementation.Elements;
using EPiServer.Forms.Samples.Implementation.Elements;
using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project.Models.Blocks
{
	[SiteContentType(GUID = "2b08d3b0-4545-4758-8cfc-76e63411cbef")]
	public class ThirdFormBlock : SiteBlockData
    {
        [Display(Order = 10, GroupName = SystemTabNames.Content)]
        public virtual RangeElementBlock RangeElement { get; set; }
	}
}
