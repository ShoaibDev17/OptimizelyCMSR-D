using Microsoft.AspNetCore.Mvc;

namespace Optimizely_Project.Controllers
{
	public class ErrorController : Controller
	{
		[HttpGet("500Error")]
		public IActionResult Index()
		{
			return Redirect("Index.html");
		}
	}
}
