using EPiServer.Forms.Controllers;
using EPiServer.Forms.Implementation.Elements;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using Microsoft.AspNetCore.Mvc;
using Optimizely_Project.Models.Blocks;

namespace Optimizely_Project.Controllers
{
    [TemplateDescriptor(AvailableWithoutTag = true,
    Default = true,
    ModelType = typeof(CustomFormContainerBlock),
    TemplateTypeCategory = TemplateTypeCategories.MvcPartialController)]
    public class CustomFormContainerBlockController : FormContainerBlockController
    {
        protected override IViewComponentResult InvokeComponent(FormContainerBlock currentBlock)
        {
            return base.InvokeComponent(currentBlock);
        }
    }
}
