using EPiServer.Forms.Core.Events;
using EPiServer.Forms.Core;
using EPiServer.Forms.Implementation.Elements;
using EPiServer.ServiceLocation;
using Optimizely_Project.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project.Models.Blocks
{
	[ContentType(DisplayName = "Standard Container",
		GUID = "9e33c5d6-4bcd-47b2-9030-be25db4941de",
		Description = "Custom form container to use in Episerver.",
		GroupName = EPiServer.Forms.Constants.FormElementGroup_Container)]
	[ServiceConfiguration(typeof(IFormContainerBlock))]

	[ImageUrl("~/resources/icons/custom-form-block.jpg")]
	public class StandardContainer : FormContainerBlock//, IFormSubmitted
	{
		//[Ignore]
		//[ScaffoldColumn(false)]
		//public string MySpecialProperty { get; set; }

		//public void OnSubmissionFinalized(object sender, FormsEventArgs e)
		//{
		//	var submittedEventArgs = e as FormsSubmittedEventArgs;
		//	MySpecialProperty = "Daved was here";
		//}
	}
}
