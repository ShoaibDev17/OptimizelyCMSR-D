using EPiServer.Forms.Core;
using EPiServer.Forms.Implementation.Elements;
using EPiServer.ServiceLocation;
using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project.Models.Blocks
{
    [ContentType(GUID = "{769ad345-6899-45e9-9300-2ac52ebdf199}", GroupName = EPiServer.Forms.Constants.FormElementGroup_Container, Order = 4000)]
    [ServiceConfiguration(typeof(IFormContainerBlock))]
    public class CustomFormContainerBlock : FormContainerBlock
    {
        [Display(Name = "Form Display Option Layout", Order = 1, GroupName = SystemTabNames.Content)]
        public virtual bool HasTwoColumns
        {
            get;
            set;
        }
    }
}
