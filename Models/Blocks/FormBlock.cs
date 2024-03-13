using EPiServer.Forms.Implementation.Elements;
using EPiServer.Forms.Samples.Implementation.Elements;

namespace Optimizely_Project.Models.Blocks
{
	[SiteContentType(
	GUID = "7fd353d1-95f2-4c32-88f3-1c96403eb74c")]
	public class FormBlock : SiteBlockData
	{
		public virtual DateTimeElementBlock DateTimeElementBlock { get; set; }
	}
}
