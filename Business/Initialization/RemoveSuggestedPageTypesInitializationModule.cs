using EPiServer.Cms.Shell.UI.Rest; // IContentTypeAdvisor
using EPiServer.Framework; // [InitializableModule], [ModuleDependency]
using EPiServer.Framework.Initialization; // InitializationEngine
using EPiServer.ServiceLocation; // IConfigurableModule,
using System.Linq; // FirstOrDefault()

namespace Optimizely_Project.Business.Initialization
{

	[InitializableModule]
	[ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
	public class RemoveSuggestedPageTypesInitializationModule : IConfigurableModule
	{
		public void ConfigureContainer(ServiceConfigurationContext context)
		{
			var descriptor = context.Services.FirstOrDefault(
			d => d.ServiceType == typeof(IContentTypeAdvisor));
			if (descriptor != null)
			{
				context.Services.Remove(descriptor);
			}
		}
		public void Initialize(InitializationEngine context) { }
		public void Uninitialize(InitializationEngine context) { }
	}
}