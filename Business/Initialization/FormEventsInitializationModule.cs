using EPiServer.Forms.Core.Events;
using EPiServer.Framework.Initialization;
using EPiServer.Framework;
using EPiServer.ServiceLocation;
using Optimizely_Project.Interfaces;

namespace Optimizely_Project.Business.Initialization
{
	[ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
	public class FormEventsInitializationModule : IInitializableModule
	{
		private Injected<FormsEvents> _formsEvents;

		public void Initialize(InitializationEngine context)
		{
			_formsEvents.Service.FormsSubmitting += OnSubmittingForm;
			_formsEvents.Service.FormsSubmissionFinalized += OnSubmissionFinalized;
			_formsEvents.Service.FormsStepSubmitted += OnStepSubmitted;
			_formsEvents.Service.FormsStructureChange += OnStructureChanged;
		}
		public void Uninitialize(InitializationEngine context)
		{
			_formsEvents.Service.FormsSubmitting -= OnSubmittingForm;
			_formsEvents.Service.FormsSubmissionFinalized -= OnSubmissionFinalized;
			_formsEvents.Service.FormsStepSubmitted -= OnStepSubmitted;
			_formsEvents.Service.FormsStructureChange -= OnStructureChanged;
		}

		private void OnSubmittingForm(object sender, FormsEventArgs e)
		{
			var form = e.FormsContent as IFormSubmitting;
			if (form == null) { return; }
			form.OnSubmittingForm(sender, e);
		}

		private void OnSubmissionFinalized(object sender, FormsEventArgs e)
		{
			var form = e.FormsContent as IFormSubmitted;
			if (form == null) { return; }
			form.OnSubmissionFinalized(sender, e);
		}

		private void OnStepSubmitted(object sender, FormsEventArgs e)
		{
			var form = e.FormsContent as IFormStepSubmitted;
			if (form == null) { return; }
			form.OnStepSubmitted(sender, e);
		}

		private void OnStructureChanged(object sender, FormsEventArgs e)
		{
			var form = e.FormsContent as IFormStructureChanged;
			if (form == null) { return; }
			form.OnFormStructureChanged(sender, e);
		}
	}
}
