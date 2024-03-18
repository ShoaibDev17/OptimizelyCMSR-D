using EPiServer.Forms.Core.Events;

namespace Optimizely_Project.Interfaces
{
	public interface IFormSubmitting
	{
		void OnSubmittingForm(object sender, FormsEventArgs e);
	}
	public interface IFormSubmitted
	{
		void OnSubmissionFinalized(object sender, FormsEventArgs e);
	}
	public interface IFormStepSubmitted
	{
		void OnStepSubmitted(object sender, FormsEventArgs e);
	}
	public interface IFormStructureChanged
	{
		void OnFormStructureChanged(object sender, FormsEventArgs e);
	}
}
