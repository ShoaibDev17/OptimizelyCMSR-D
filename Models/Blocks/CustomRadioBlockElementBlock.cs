using EPiServer.Forms.EditView.Models.Internal;
using EPiServer.Forms.Implementation.Elements;

namespace Optimizely_Project.Models.Blocks
{
	[ContentType(
		   DisplayName = "Culture Specific SelectionBlock",
		   GUID = "6c232615-1a9d-4eb5-8226-cbee2de9111a",
		   Description = "Use when you need the options in another language",
		   GroupName = "Custom Elements")]
	public class CustomRadioBlockElementBlock : TextareaElementBlock
	{
		//[CultureSpecific]
		//public override IEnumerable<OptionItem> Items { get; set; }
	}
}
