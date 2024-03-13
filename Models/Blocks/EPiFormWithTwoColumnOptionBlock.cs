using EPiServer.Forms.Core;
using EPiServer.Forms.Implementation.Elements;
using EPiServer.ServiceLocation;
using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project.Models.Blocks
{
    [ContentType(
        GUID = "{df00b0c8-3b68-453b-a44c-8bf8392e4ff2}",
        GroupName = EPiServer.Forms.Constants.FormElementGroup_Container,
        Order = 4000)]
    [ServiceConfiguration(typeof(IFormContainerBlock))]
    public class EPiFormWithTwoColumnOptionBlockAgain : FormContainerBlock
    {
        [Display(Name = "Use two column layout", Order = 1, GroupName = SystemTabNames.Content)]
        public virtual bool HasTwoColumns { get; set; }
    }
}
