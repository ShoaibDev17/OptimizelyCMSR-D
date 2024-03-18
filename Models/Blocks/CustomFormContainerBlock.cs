using EPiServer.Forms.Core;
using EPiServer.Forms.Implementation.Elements;
using EPiServer.ServiceLocation;

namespace Optimizely_Project.Models.Blocks
{
    [ContentType(DisplayName = "Custom Standard Container",
    GUID = "c24ead35-a13d-478a-ac15-941e74bd7bc0",
    Description = "Custom form Episerver.",
    GroupName = EPiServer.Forms.Constants.FormElementGroup_Container)]
    [ServiceConfiguration(typeof(IFormContainerBlock))]

    [ImageUrl("~/resources/icons/custom-form-block.jpg")]
    public class CustomFormContainerBlock : FormContainerBlock
    {
        public virtual string CustomName { get;set; }
    }
}
