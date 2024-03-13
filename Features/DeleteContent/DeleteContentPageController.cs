using Optimizely_Project.Controllers; // PageControllerBase<T>
using Optimizely_Project.Models.ViewModels; // PageViewModel
using EPiServer; // IContentRepository
using EPiServer.Core; // ContentReference, IContent
using EPiServer.Security; // AccessLevel
using Microsoft.AspNetCore.Mvc;
using AlloyDemo.Features.DeleteContent; // IActionResult, [HttpPost]

namespace Optimizely_Project.Features.DeleteContent
{
    public class DeleteContentPageController : PageControllerBase<DeleteContentPage>
    {
        private readonly IContentRepository repo = null;

        public DeleteContentPageController(IContentRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index(DeleteContentPage currentPage)
        {
            return View("~/Features/DeleteContent/DeleteContentPage.cshtml", 
                PageViewModel.Create(currentPage));
        }

        [HttpPost]
        public IActionResult Delete(DeleteContentPage currentPage, 
            ContentReference contentReference, string hardDelete)
        {
            string name = repo.Get<IContent>(contentReference).Name;

            if (hardDelete == "on")
            {
                repo.Delete(contentReference, forceDelete: true, 
                    access: AccessLevel.NoAccess);

                ViewData["message"] = $"'{name}' was deleted permanently.";
            }
            else
            {
                repo.Move(contentReference, destination: ContentReference.WasteBasket,
                    requiredSourceAccess: AccessLevel.NoAccess,
                    requiredDestinationAccess: AccessLevel.NoAccess);

                ViewData["message"] = $"'{name}' was moved to trash.";
            }
            
            return View("~/Features/DeleteContent/DeleteContentPage.cshtml",
                PageViewModel.Create(currentPage));
        }
    }
}