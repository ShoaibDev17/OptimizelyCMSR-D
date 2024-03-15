using EPiServer.Forms.Core;
using EPiServer.Forms.Implementation.Elements;
using EPiServer.ServiceLocation;
using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project.Models.Blocks
{
    [ContentType(
     GUID = "{e876fd34-55e0-4fc1-a5a8-6b8332cba299}",
     GroupName = EPiServer.Forms.Constants.FormElementGroup_Container,
     Order = 4000)]
    [ServiceConfiguration(typeof(IFormContainerBlock))]
    public class NewBlockView : FormContainerBlock
    {
        [Display(Name = "Use two column layout", Order = 1, GroupName = SystemTabNames.Content)]
        public virtual bool HasTwoColumns { get; set; }
    }
}
