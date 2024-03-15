using EPiServer.Forms.Core;
using EPiServer.Forms.Implementation.Elements;
using EPiServer.ServiceLocation;
using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project.Models.Blocks
{
        [ContentType(
        GUID = "{377bc907-ca21-4790-8946-ac04be22ee38}",
        GroupName = EPiServer.Forms.Constants.FormElementGroup_Container,
        Order = 4000)]
        [ServiceConfiguration(typeof(IFormContainerBlock))]
        public class MultiRazorView : FormContainerBlock
        {
            [Display(Name = "Use two column layout", Order = 1, GroupName = SystemTabNames.Content)]
            public virtual bool HasTwoColumns { get; set; }
        }
}
