using Optimizely_Project.Models.Pages; // SitePageData
using EPiServer; // IContentLoader
using EPiServer.Core; // IContentEvents, IContent
using EPiServer.Framework; // [InitializableModule], [ModuleDependency]
using EPiServer.Framework.Initialization; // InitializationEngine
using System.Linq; // Count()
namespace Optimizely_Project.Business.Initialization
{
	[InitializableModule]
	[ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
	public class PreventMoreThanMaxChildrenInitializationModule : IInitializableModule
	{
		private bool initialized = false;
		private IContentEvents events;
		private IContentLoader loader;
		private const int maxChildren = 10;
		public void Initialize(InitializationEngine context)
		{
			if (!initialized)
			{
				loader = context.Locate.ContentLoader();
				events = context.Locate.ContentEvents();
				events.CreatingContent += Events_CreatingContent;
				initialized = true;
			}
		}
		private void Events_CreatingContent(object sender, ContentEventArgs e)
		{
			var sitepage = e.Content as SitePageData;
			if (sitepage != null)
			{
				var children = loader.GetChildren<IContent>(sitepage.ParentLink);
				if (children.Count() >= maxChildren)
				{
					e.CancelAction = true;
					e.CancelReason =
					 $"Cannot create a new page if the parent has {maxChildren} or more children.";
				}
			}
		}

		public void Uninitialize(InitializationEngine context)
		{
			if (initialized)
			{
				events.CreatingContent -= Events_CreatingContent;
			}
		}
	}
}
